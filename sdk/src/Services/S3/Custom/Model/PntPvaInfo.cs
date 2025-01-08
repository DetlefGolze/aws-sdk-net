using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container stores information about the physical media location of an object
	/// or object part on a protected volume array (PVA).
    /// </summary>
    public class PntPvaInfo
    {
        private string _uuid;
        private long? _offset;
		private int? _totalCount;

        /// <summary>
        /// Gets and sets the property Uuid. 
        /// <para>
        /// Specifies the unique ID of the PVA the queried object or part is
        /// is stored on.
        /// </para>
        /// </summary>
        public string Uuid
        {
            get { return this._uuid; }
            set { this._uuid = value; }
        }

        /// <summary>
        /// Gets and sets the property Offset. 
        /// <para>
        /// If present, the Offset specifies the data offset within the PVA
        /// </para>
        /// </summary>
        public long? Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// If present, specifies the total number of PVAs sections referenced by the
		/// queried object or part.
        /// </para>
		/// 
        /// <para>
        /// If this value is not set, then it can be assumed as 1.
        /// </para>
        /// </summary>
		public int? TotalCount
		{
            get { return this._totalCount; }
            set { this._totalCount = value; }
		}
    }
}
