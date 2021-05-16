using System;


namespace TalebiAPI.Domain
{
    public class User
    {
        public Guid Guid { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }


    public class SingleResponse<T>
    {
        public bool HasError { get; set; }
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
        
    }
}
