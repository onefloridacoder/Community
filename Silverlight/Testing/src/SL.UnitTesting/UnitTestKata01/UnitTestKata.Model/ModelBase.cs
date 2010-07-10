using System.ComponentModel;
namespace UnitTestKata.Model
{
    public class ModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void FirePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private long id;
        public long Id
        {
            get { return id; }
            set 
            { 
                id = value;
                this.FirePropertyChanged("Id");
            }
        }

        private byte[] timestamp;
        public byte[] Timestamp
        {
            get { return timestamp; }
            set
            {
                timestamp = value;
                this.FirePropertyChanged("Timestamp");
            }
        }

        private string lastUpdatedBy;
        public string LastUpdatedBy
        {
            get { return lastUpdatedBy; ; }
            set
            {
                lastUpdatedBy = value;
                this.FirePropertyChanged("LastUpdatedBy");
            }
        }
    }
}
