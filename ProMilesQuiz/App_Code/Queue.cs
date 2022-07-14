using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Queue
/// </summary>
public class Queue
{
    public Queue()
    {
        //
        // TODO: Add constructor logic here
        //
        

    }

    public long ID { get; set; }
    public string Name { get; set; }
    public int ProcessOrder { get; set; }
    public bool? Default { get; set; }
    public bool? Permits { get; set; }
    public bool? Envelopes { get; set; }
    public bool? Statuses { get; set; }
    public bool? OutOfOrderAccess { get; set; }
    public bool? WorkingQueueOnly { get; set; }
    public bool? AmmendRequest { get; set; }
    public bool? QueBalancingMode { get; set; }

}