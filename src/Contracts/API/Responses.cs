namespace Bdaya.Net.Responses.Contracts.API
{
    public static class Responses
    {
        public static class Delete
        {
            public static readonly ResponseViewModel Success = new ResponseViewModel { Message = "Deleted Successfuly", Status = true };
            public static readonly ResponseViewModel Fail = new ResponseViewModel { Message = "Failed to delete", Status = false };
        }

        public static class Create
        {
            public static readonly ResponseViewModel Success = new ResponseViewModel { Message = "Created Successfuly", Status = true };
            public static readonly ResponseViewModel Fail = new ResponseViewModel { Message = "Failed to Create", Status = false };
        }
        public static class Update
        {
            public static readonly ResponseViewModel Success = new ResponseViewModel { Message = "Updated Successfuly", Status = true };
            public static readonly ResponseViewModel Fail = new ResponseViewModel { Message = "Failed to update", Status = false };
        }

        public static class Transaction
        {
            public static readonly ResponseViewModel Success = new ResponseViewModel { Message = "Success Process", Status = true };
            public static readonly ResponseViewModel Fail = new ResponseViewModel { Message = "Fail of Process", Status = false };
        }

    }
}
