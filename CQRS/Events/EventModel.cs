using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Events
{
    [Table("EventTable")]
    public class EventModel
    {
        public EventModel(string id, DateTime timeStamp,string aggregationId,string aggregateType,int version,string eventType,BaseEvent eventData)
        {
            this.id = id;
            this.timeStamp = timeStamp;
            this.aggregationId = aggregationId;
            this.aggregateType = aggregateType;
            this.version = version;
            this.eventType = eventType;
            //this.eventData = eventData;
        }

        [Key]
        public String id { get; set; }
        public DateTime timeStamp { get; set; }
        public String aggregationId { get; set; }
        public String aggregateType { get; set; }
        public int version { get; set; }
        public String eventType { get; set; }
        public BaseEvent eventData { get; set; }
    }
}
