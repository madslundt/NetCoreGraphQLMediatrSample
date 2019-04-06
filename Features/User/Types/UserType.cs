﻿using GraphQL.Types;

namespace Features.User.Types
{
    public class UserType : ObjectGraphType<DataModel.Models.User>
    {
        public UserType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description($"ID of {Name}");
            Field(x => x.FirstName).Description($"First name of {Name}");
            Field(x => x.LastName).Description($"Last name of {Name}");
            Field(x => x.Status, type: typeof(UserStatusType)).Description($"Status of {Name}");
        }
    }
}
