namespace UnitTestKata.Model
{
    public class Person : ModelBase
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set 
            { 
                firstName = value;
                FirePropertyChanged("FirstName");
            }
        }
        
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set 
            { 
                lastName = value;
                FirePropertyChanged("LastName");
            }
        }

        public override string ToString()
        { 
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
