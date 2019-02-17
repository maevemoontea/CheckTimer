using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace CheckTimerLib
{
    [DataContract]
    class Record
    {
        [DataMember]
        private DateTime startTime;
        [DataMember]
        private DateTime endTime;
        [DataMember]
        private string taskName;

        public DateTime StartTime { get { return startTime; } }
        public DateTime EndTime { get { return endTime; } }
        public string TaskName { get { return taskName; } }

        public Record(DateTime start, DateTime end, string task)
        {
            startTime = start;
            endTime = end;
            taskName = task;
        }
        public void Print()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Record));
            using (FileStream fs = new FileStream("record.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, this);
            }
        }
    }
}
