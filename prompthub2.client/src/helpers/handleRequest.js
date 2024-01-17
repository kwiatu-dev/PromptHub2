const handleRequest = async (apiFunction, endpoint, payload) => {
  try{
    const response = await apiFunction(endpoint, payload)
    return { success: true, result: response.data }
  }
  catch(error){
    return { success: false, result: error.response.data }
  }
}

export default handleRequest