//----------------------------------------------------------------
// <auto-generated>
//     This code was generated by the GenMsg. Version: 0.1.0.0
//     Don't change it manually.
//     2012-04-07T13:04:51+09:00
// </auto-generated>
//----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RosSharp.Message;
using RosSharp.Service;
namespace RosSharp.std_msgs
{
    public class Int8MultiArray : IMessage
    {
        public Int8MultiArray()
        {
            layout = new MultiArrayLayout();
            data = new List<sbyte>();
        }
        public Int8MultiArray(BinaryReader br)
        {
            Deserialize(br);
        }
        public MultiArrayLayout layout { get; set; }
        public List<sbyte> data { get; set; }
        public string MessageType
        {
            get { return "std_msgs/Int8MultiArray"; }
        }
        public string Md5Sum
        {
            get { return "9d4140697a6ec8c3eafcabc04dda8db9"; }
        }
        public string MessageDefinition
        {
            get { return "MultiArrayLayout layout\nint8[] data"; }
        }
        public void Serialize(BinaryWriter bw)
        {
            layout.Serialize(bw);
            bw.Write(data.Count); for(int i=0; i<data.Count; i++) { bw.Write(data[i]);}
        }
        public void Deserialize(BinaryReader br)
        {
            layout = new MultiArrayLayout();
            data = new List<sbyte>(br.ReadInt32()); for(int i=0; i<data.Count; i++) { data[i] = br.ReadSByte();}
        }
        public int SerializeLength
        {
            get { return layout.SerializeLength + data.Sum(x => 1); }
        }
        public bool Equals(Int8MultiArray other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.layout.Equals(layout) && other.data.Equals(data);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Int8MultiArray)) return false;
            return Equals((Int8MultiArray)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ layout.GetHashCode();
                result = (result * 397) ^ data.GetHashCode();
                return result;
            }
        }
    }
}