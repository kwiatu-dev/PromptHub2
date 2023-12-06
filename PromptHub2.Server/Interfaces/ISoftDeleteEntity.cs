namespace PromptHub2.Server.Interfaces
{
    public interface ISoftDeleteEntity
    {
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        public void Undo()
        {
            IsDeleted = false;
            DeletedAt = null;
        }
    }
}
