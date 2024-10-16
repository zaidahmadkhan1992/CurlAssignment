namespace Demo.Connection
{
    public class Connection : IConnection
    {
       // public int getConnection => throw new NotImplementedException();
        public Connection(string con) {
            getConnection = con;
        }

        private string _getConnection=""; // field

        public string getConnection   // property
        {
            get { return _getConnection; }   // get method
            set { _getConnection = value; }  // set method
        }
         
    }
}
