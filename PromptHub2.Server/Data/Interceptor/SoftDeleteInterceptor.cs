using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using PromptHub2.Server.Interfaces;

public class SoftDeleteInterceptor : SaveChangesInterceptor
{
    public override InterceptionResult<int> SavingChanges(
        DbContextEventData eventData,
        InterceptionResult<int> result)
    {
        if (eventData.Context is null)
        {
            return result;
        }

        var entries = eventData.Context.ChangeTracker.Entries<ISoftDeleteEntity>();

        foreach (var entry in entries)
        {
            if (entry.State == EntityState.Deleted)
            {
                entry.State = EntityState.Modified;
                entry.Entity.IsDeleted = true;
                entry.Entity.DeletedAt = DateTime.UtcNow;
            }

            if (entry.State == EntityState.Added)
            {
                entry.Entity.IsDeleted = false;
            }
        }

        return result;
    }

    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = default)
    {
        if (eventData.Context is null)
        {
            return new ValueTask<InterceptionResult<int>>(result);
        }

        var entries = eventData.Context.ChangeTracker.Entries<ISoftDeleteEntity>();

        foreach (var entry in entries)
        {
            if(entry.State == EntityState.Deleted)
            {
                entry.State = EntityState.Modified;
                entry.Entity.IsDeleted = true;
                entry.Entity.DeletedAt = DateTime.UtcNow;
            }

            if (entry.State == EntityState.Added)
            {
                entry.Entity.IsDeleted = false;
            }
        }

        return new ValueTask<InterceptionResult<int>>(result);
    }
}