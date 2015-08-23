using System;
using System.Collections.Generic;
using System.Text;

namespace zaftime.Data
{
    /// <summary>
    /// Kelas untuk menyimpan data sebuah group
    /// </summary>
    public class SeriesGroup : ICloneable
    {
        private string groupName;
        private SeriesVariables groupList;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">nama group</param>
        /// <param name="groupList">list variabel anggota group</param>
        public SeriesGroup(string name, SeriesVariables groupList)
        {
            this.groupName = name;
            this.groupList = groupList;            
        }

        /// <summary>
        /// Nama group
        /// </summary>
        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }

        /// <summary>
        /// List variabel anggota group
        /// </summary>
        public SeriesVariables GroupList
        {
            get { return groupList; }
            set { groupList = value; }
        }
        
        /// <summary>
        /// Indexer. mengakses variabel anggota pada index tertentu
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>variabel yang dituju</returns>
        public SeriesVariable this[int index]
        {
            get { return this.groupList[index]; }
            set { this.groupList[index] = value; }
        }

        #region override

        /// <summary>
        /// Nilai string yang mewakili objek
        /// </summary>
        /// <returns>String nama group</returns>
        public override string ToString()
        {
            return this.groupName;
        }

        #endregion

        #region ICloneable Members

        /// <summary>
        /// Mengkloning group
        /// </summary>
        /// <returns>group baru dengan nilai sama dengan group asal</returns>
        public object Clone()
        {
            SeriesGroup clone = new SeriesGroup(this.groupName, (SeriesVariables)this.groupList.Clone());
            return clone;
        }

        #endregion
    }
}
