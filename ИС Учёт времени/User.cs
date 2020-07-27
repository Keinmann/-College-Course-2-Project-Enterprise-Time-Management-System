using System;

namespace ИС_Учёт_времени
{
    public class User
    {
        public bool authorized;
        public UInt32 id,useraccess,statusid,scheduleid;
        public string username, usersurname, userlastname;
        public void Clear() 
        {
            authorized = false;
            id = useraccess = statusid = scheduleid = 0;
            username = usersurname = userlastname =  "";
        }

    }
}
