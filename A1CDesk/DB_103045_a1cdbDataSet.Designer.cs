﻿// ***********************************************************************
// Assembly         : A1CDesk
// Author           : m_c_w
// Created          : 10-05-2019
//
// Last Modified By : m_c_w
// Last Modified On : 10-05-2019
// ***********************************************************************
// <copyright file="DB_103045_a1cdbDataSet.Designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************

#pragma warning disable 1591

namespace A1CDesk {


    /// <summary>
    /// Represents a strongly typed in-memory cache of data.
    /// Implements the <see cref="System.Data.DataSet" />
    /// </summary>
    /// <seealso cref="System.Data.DataSet" />
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("DB_103045_a1cdbDataSet")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class DB_103045_a1cdbDataSet : global::System.Data.DataSet {

        /// <summary>
        /// The tabletbl a1 c
        /// </summary>
        private tbl_A1CDataTable tabletbl_A1C;

        /// <summary>
        /// The schema serialization mode
        /// </summary>
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;

        /// <summary>
        /// Initializes a new instance of the <see cref="DB_103045_a1cdbDataSet"/> class.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public DB_103045_a1cdbDataSet() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DB_103045_a1cdbDataSet"/> class.
        /// </summary>
        /// <param name="info">The data needed to serialize or deserialize an object.</param>
        /// <param name="context">The source and destination of a given serialized stream.</param>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected DB_103045_a1cdbDataSet(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["tbl_A1C"] != null)) {
                    base.Tables.Add(new tbl_A1CDataTable(ds.Tables["tbl_A1C"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }

        /// <summary>
        /// Gets the table a1 c.
        /// </summary>
        /// <value>The table a1 c.</value>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public tbl_A1CDataTable tbl_A1C {
            get {
                return this.tabletbl_A1C;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.Data.SchemaSerializationMode" /> for a <see cref="T:System.Data.DataSet" />.
        /// </summary>
        /// <value>The schema serialization mode.</value>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }

        /// <summary>
        /// Gets the collection of tables contained in the <see cref="T:System.Data.DataSet" />.
        /// </summary>
        /// <value>The tables.</value>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }

        /// <summary>
        /// Get the collection of relations that link tables and allow navigation from parent tables to child tables.
        /// </summary>
        /// <value>The relations.</value>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }

        /// <summary>
        /// Deserialize all of the tables data of the DataSet from the binary or XML stream.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }

        /// <summary>
        /// Copies the structure of the <see cref="T:System.Data.DataSet" />, including all <see cref="T:System.Data.DataTable" /> schemas, relations, and constraints. Does not copy any data.
        /// </summary>
        /// <returns>A new <see cref="T:System.Data.DataSet" /> with the same schema as the current <see cref="T:System.Data.DataSet" />, but none of the data.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public override global::System.Data.DataSet Clone() {
            DB_103045_a1cdbDataSet cln = ((DB_103045_a1cdbDataSet)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }

        /// <summary>
        /// Gets a value indicating whether <see cref="P:System.Data.DataSet.Tables" /> property should be persisted.
        /// </summary>
        /// <returns><see langword="true" /> if the property value has been changed from its default; otherwise <see langword="false" />.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override bool ShouldSerializeTables() {
            return false;
        }

        /// <summary>
        /// Gets a value indicating whether <see cref="P:System.Data.DataSet.Relations" /> property should be persisted.
        /// </summary>
        /// <returns><see langword="true" /> if the property value has been changed from its default; otherwise <see langword="false" />.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override bool ShouldSerializeRelations() {
            return false;
        }

        /// <summary>
        /// Ignores attributes and returns an empty DataSet.
        /// </summary>
        /// <param name="reader">The specified XML reader.</param>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["tbl_A1C"] != null)) {
                    base.Tables.Add(new tbl_A1CDataTable(ds.Tables["tbl_A1C"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }

        /// <summary>
        /// Returns a serializable <see cref="T:System.Xml.Schema.XMLSchema" /> instance.
        /// </summary>
        /// <returns>The <see cref="T:System.Xml.Schema.XMLSchema" /> instance.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }

        /// <summary>
        /// Initializes the vars.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal void InitVars() {
            this.InitVars(true);
        }

        /// <summary>
        /// Initializes the vars.
        /// </summary>
        /// <param name="initTable">if set to <c>true</c> [initialize table].</param>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal void InitVars(bool initTable) {
            this.tabletbl_A1C = ((tbl_A1CDataTable)(base.Tables["tbl_A1C"]));
            if ((initTable == true)) {
                if ((this.tabletbl_A1C != null)) {
                    this.tabletbl_A1C.InitVars();
                }
            }
        }

        /// <summary>
        /// Initializes the class.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitClass() {
            this.DataSetName = "DB_103045_a1cdbDataSet";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/DB_103045_a1cdbDataSet.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tabletbl_A1C = new tbl_A1CDataTable();
            base.Tables.Add(this.tabletbl_A1C);
        }

        /// <summary>
        /// Shoulds the serializetbl a1 c.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private bool ShouldSerializetbl_A1C() {
            return false;
        }

        /// <summary>
        /// Schemas the changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.ComponentModel.CollectionChangeEventArgs"/> instance containing the event data.</param>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }

        /// <summary>
        /// Gets the typed data set schema.
        /// </summary>
        /// <param name="xs">The xs.</param>
        /// <returns>System.Xml.Schema.XmlSchemaComplexType.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            DB_103045_a1cdbDataSet ds = new DB_103045_a1cdbDataSet();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }

        /// <summary>
        /// Delegate tbl_A1CRowChangeEventHandler
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public delegate void tbl_A1CRowChangeEventHandler(object sender, tbl_A1CRowChangeEvent e);

        /// <summary>
        /// Represents the strongly named DataTable class.
        /// Implements the <see cref="System.Data.TypedTableBase{A1CDesk.DB_103045_a1cdbDataSet.tbl_A1CRow}" />
        /// </summary>
        /// <seealso cref="System.Data.TypedTableBase{A1CDesk.DB_103045_a1cdbDataSet.tbl_A1CRow}" />
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class tbl_A1CDataTable : global::System.Data.TypedTableBase<tbl_A1CRow> {

            /// <summary>
            /// The column identifier
            /// </summary>
            private global::System.Data.DataColumn columnId;

            /// <summary>
            /// The columnuser identifier
            /// </summary>
            private global::System.Data.DataColumn columnuserID;

            /// <summary>
            /// The column reading date
            /// </summary>
            private global::System.Data.DataColumn columnReading_Date;

            /// <summary>
            /// The column reading tod
            /// </summary>
            private global::System.Data.DataColumn columnReading_TOD;

            /// <summary>
            /// The column reading value
            /// </summary>
            private global::System.Data.DataColumn columnReading_Value;

            /// <summary>
            /// The column comments
            /// </summary>
            private global::System.Data.DataColumn columnComments;

            /// <summary>
            /// Initializes a new instance of the <see cref="tbl_A1CDataTable"/> class.
            /// </summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public tbl_A1CDataTable() {
                this.TableName = "tbl_A1C";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="tbl_A1CDataTable"/> class.
            /// </summary>
            /// <param name="table">The table.</param>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal tbl_A1CDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="tbl_A1CDataTable"/> class.
            /// </summary>
            /// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that contains data to construct the object.</param>
            /// <param name="context">The streaming context for the object being deserializad.</param>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected tbl_A1CDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }

            /// <summary>
            /// Gets the identifier column.
            /// </summary>
            /// <value>The identifier column.</value>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn IdColumn {
                get {
                    return this.columnId;
                }
            }

            /// <summary>
            /// Gets the user identifier column.
            /// </summary>
            /// <value>The user identifier column.</value>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn userIDColumn {
                get {
                    return this.columnuserID;
                }
            }

            /// <summary>
            /// Gets the reading date column.
            /// </summary>
            /// <value>The reading date column.</value>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Reading_DateColumn {
                get {
                    return this.columnReading_Date;
                }
            }

            /// <summary>
            /// Gets the reading tod column.
            /// </summary>
            /// <value>The reading tod column.</value>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Reading_TODColumn {
                get {
                    return this.columnReading_TOD;
                }
            }

            /// <summary>
            /// Gets the reading value column.
            /// </summary>
            /// <value>The reading value column.</value>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Reading_ValueColumn {
                get {
                    return this.columnReading_Value;
                }
            }

            /// <summary>
            /// Gets the comments column.
            /// </summary>
            /// <value>The comments column.</value>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn CommentsColumn {
                get {
                    return this.columnComments;
                }
            }

            /// <summary>
            /// Gets the count.
            /// </summary>
            /// <value>The count.</value>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }

            /// <summary>
            /// Gets the <see cref="tbl_A1CRow"/> at the specified index.
            /// </summary>
            /// <param name="index">The index.</param>
            /// <returns>tbl_A1CRow.</returns>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public tbl_A1CRow this[int index] {
                get {
                    return ((tbl_A1CRow)(this.Rows[index]));
                }
            }

            /// <summary>
            /// Occurs when [table a1 c row changing].
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event tbl_A1CRowChangeEventHandler tbl_A1CRowChanging;

            /// <summary>
            /// Occurs when [table a1 c row changed].
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event tbl_A1CRowChangeEventHandler tbl_A1CRowChanged;

            /// <summary>
            /// Occurs when [table a1 c row deleting].
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event tbl_A1CRowChangeEventHandler tbl_A1CRowDeleting;

            /// <summary>
            /// Occurs when [table a1 c row deleted].
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event tbl_A1CRowChangeEventHandler tbl_A1CRowDeleted;

            /// <summary>
            /// Addtbls the a1 c row.
            /// </summary>
            /// <param name="row">The row.</param>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void Addtbl_A1CRow(tbl_A1CRow row) {
                this.Rows.Add(row);
            }

            /// <summary>
            /// Addtbls the a1 c row.
            /// </summary>
            /// <param name="userID">The user identifier.</param>
            /// <param name="Reading_Date">The reading date.</param>
            /// <param name="Reading_TOD">The reading tod.</param>
            /// <param name="Reading_Value">The reading value.</param>
            /// <param name="Comments">The comments.</param>
            /// <returns>tbl_A1CRow.</returns>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public tbl_A1CRow Addtbl_A1CRow(string userID, System.DateTime Reading_Date, string Reading_TOD, int Reading_Value, string Comments) {
                tbl_A1CRow rowtbl_A1CRow = ((tbl_A1CRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        userID,
                        Reading_Date,
                        Reading_TOD,
                        Reading_Value,
                        Comments};
                rowtbl_A1CRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowtbl_A1CRow);
                return rowtbl_A1CRow;
            }

            /// <summary>
            /// Finds the by identifier.
            /// </summary>
            /// <param name="Id">The identifier.</param>
            /// <returns>tbl_A1CRow.</returns>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public tbl_A1CRow FindById(int Id) {
                return ((tbl_A1CRow)(this.Rows.Find(new object[] {
                            Id})));
            }

            /// <summary>
            /// Clones the structure of the <see cref="T:System.Data.DataTable" />, including all <see cref="T:System.Data.DataTable" /> schemas and constraints.
            /// </summary>
            /// <returns>A new <see cref="T:System.Data.DataTable" /> with the same schema as the current <see cref="T:System.Data.DataTable" />.</returns>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                tbl_A1CDataTable cln = ((tbl_A1CDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }

            /// <summary>
            /// Creates a new instance of <see cref="T:System.Data.DataTable" />.
            /// </summary>
            /// <returns>The new expression.</returns>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new tbl_A1CDataTable();
            }

            /// <summary>
            /// Initializes the vars.
            /// </summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal void InitVars() {
                this.columnId = base.Columns["Id"];
                this.columnuserID = base.Columns["userID"];
                this.columnReading_Date = base.Columns["Reading_Date"];
                this.columnReading_TOD = base.Columns["Reading_TOD"];
                this.columnReading_Value = base.Columns["Reading_Value"];
                this.columnComments = base.Columns["Comments"];
            }

            /// <summary>
            /// Initializes the class.
            /// </summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private void InitClass() {
                this.columnId = new global::System.Data.DataColumn("Id", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnId);
                this.columnuserID = new global::System.Data.DataColumn("userID", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnuserID);
                this.columnReading_Date = new global::System.Data.DataColumn("Reading_Date", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnReading_Date);
                this.columnReading_TOD = new global::System.Data.DataColumn("Reading_TOD", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnReading_TOD);
                this.columnReading_Value = new global::System.Data.DataColumn("Reading_Value", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnReading_Value);
                this.columnComments = new global::System.Data.DataColumn("Comments", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnComments);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnId}, true));
                this.columnId.AutoIncrement = true;
                this.columnId.AutoIncrementSeed = -1;
                this.columnId.AutoIncrementStep = -1;
                this.columnId.AllowDBNull = false;
                this.columnId.ReadOnly = true;
                this.columnId.Unique = true;
                this.columnuserID.AllowDBNull = false;
                this.columnuserID.MaxLength = 50;
                this.columnReading_Date.AllowDBNull = false;
                this.columnReading_TOD.AllowDBNull = false;
                this.columnReading_TOD.MaxLength = 16;
                this.columnReading_Value.AllowDBNull = false;
                this.columnComments.MaxLength = 2147483647;
            }

            /// <summary>
            /// Newtbls the a1 c row.
            /// </summary>
            /// <returns>tbl_A1CRow.</returns>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public tbl_A1CRow Newtbl_A1CRow() {
                return ((tbl_A1CRow)(this.NewRow()));
            }

            /// <summary>
            /// Creates a new row from an existing row.
            /// </summary>
            /// <param name="builder">A <see cref="T:System.Data.DataRowBuilder" /> object.</param>
            /// <returns>A <see cref="T:System.Data.DataRow" /> derived class.</returns>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new tbl_A1CRow(builder);
            }

            /// <summary>
            /// Gets the row type.
            /// </summary>
            /// <returns>Returns the type of the <see cref="T:System.Data.DataRow" />.</returns>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(tbl_A1CRow);
            }

            /// <summary>
            /// Raises the <see cref="E:System.Data.DataTable.RowChanged" /> event.
            /// </summary>
            /// <param name="e">A <see cref="T:System.Data.DataRowChangeEventArgs" /> that contains the event data.</param>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tbl_A1CRowChanged != null)) {
                    this.tbl_A1CRowChanged(this, new tbl_A1CRowChangeEvent(((tbl_A1CRow)(e.Row)), e.Action));
                }
            }

            /// <summary>
            /// Raises the <see cref="E:System.Data.DataTable.RowChanging" /> event.
            /// </summary>
            /// <param name="e">A <see cref="T:System.Data.DataRowChangeEventArgs" /> that contains the event data.</param>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tbl_A1CRowChanging != null)) {
                    this.tbl_A1CRowChanging(this, new tbl_A1CRowChangeEvent(((tbl_A1CRow)(e.Row)), e.Action));
                }
            }

            /// <summary>
            /// Raises the <see cref="E:System.Data.DataTable.RowDeleted" /> event.
            /// </summary>
            /// <param name="e">A <see cref="T:System.Data.DataRowChangeEventArgs" /> that contains the event data.</param>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tbl_A1CRowDeleted != null)) {
                    this.tbl_A1CRowDeleted(this, new tbl_A1CRowChangeEvent(((tbl_A1CRow)(e.Row)), e.Action));
                }
            }

            /// <summary>
            /// Raises the <see cref="E:System.Data.DataTable.RowDeleting" /> event.
            /// </summary>
            /// <param name="e">A <see cref="T:System.Data.DataRowChangeEventArgs" /> that contains the event data.</param>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tbl_A1CRowDeleting != null)) {
                    this.tbl_A1CRowDeleting(this, new tbl_A1CRowChangeEvent(((tbl_A1CRow)(e.Row)), e.Action));
                }
            }

            /// <summary>
            /// Removetbls the a1 c row.
            /// </summary>
            /// <param name="row">The row.</param>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void Removetbl_A1CRow(tbl_A1CRow row) {
                this.Rows.Remove(row);
            }

            /// <summary>
            /// Gets the typed table schema.
            /// </summary>
            /// <param name="xs">The xs.</param>
            /// <returns>System.Xml.Schema.XmlSchemaComplexType.</returns>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                DB_103045_a1cdbDataSet ds = new DB_103045_a1cdbDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "tbl_A1CDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }

        /// <summary>
        /// Represents strongly named DataRow class.
        /// Implements the <see cref="System.Data.DataRow" />
        /// </summary>
        /// <seealso cref="System.Data.DataRow" />
        public partial class tbl_A1CRow : global::System.Data.DataRow {

            /// <summary>
            /// The tabletbl a1 c
            /// </summary>
            private tbl_A1CDataTable tabletbl_A1C;

            /// <summary>
            /// Initializes a new instance of the <see cref="tbl_A1CRow"/> class.
            /// </summary>
            /// <param name="rb">The rb.</param>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal tbl_A1CRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tabletbl_A1C = ((tbl_A1CDataTable)(this.Table));
            }

            /// <summary>
            /// Gets or sets the identifier.
            /// </summary>
            /// <value>The identifier.</value>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Id {
                get {
                    return ((int)(this[this.tabletbl_A1C.IdColumn]));
                }
                set {
                    this[this.tabletbl_A1C.IdColumn] = value;
                }
            }

            /// <summary>
            /// Gets or sets the user identifier.
            /// </summary>
            /// <value>The user identifier.</value>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string userID {
                get {
                    return ((string)(this[this.tabletbl_A1C.userIDColumn]));
                }
                set {
                    this[this.tabletbl_A1C.userIDColumn] = value;
                }
            }

            /// <summary>
            /// Gets or sets the reading date.
            /// </summary>
            /// <value>The reading date.</value>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public System.DateTime Reading_Date {
                get {
                    return ((global::System.DateTime)(this[this.tabletbl_A1C.Reading_DateColumn]));
                }
                set {
                    this[this.tabletbl_A1C.Reading_DateColumn] = value;
                }
            }

            /// <summary>
            /// Gets or sets the reading tod.
            /// </summary>
            /// <value>The reading tod.</value>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Reading_TOD {
                get {
                    return ((string)(this[this.tabletbl_A1C.Reading_TODColumn]));
                }
                set {
                    this[this.tabletbl_A1C.Reading_TODColumn] = value;
                }
            }

            /// <summary>
            /// Gets or sets the reading value.
            /// </summary>
            /// <value>The reading value.</value>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Reading_Value {
                get {
                    return ((int)(this[this.tabletbl_A1C.Reading_ValueColumn]));
                }
                set {
                    this[this.tabletbl_A1C.Reading_ValueColumn] = value;
                }
            }

            /// <summary>
            /// Gets or sets the comments.
            /// </summary>
            /// <value>The comments.</value>
            /// <exception cref="System.Data.StrongTypingException">The value for column \'Comments\' in table \'tbl_A1C\' is DBNull.</exception>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Comments {
                get {
                    try {
                        return ((string)(this[this.tabletbl_A1C.CommentsColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Comments\' in table \'tbl_A1C\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tabletbl_A1C.CommentsColumn] = value;
                }
            }

            /// <summary>
            /// Determines whether [is comments null].
            /// </summary>
            /// <returns><c>true</c> if [is comments null]; otherwise, <c>false</c>.</returns>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsCommentsNull() {
                return this.IsNull(this.tabletbl_A1C.CommentsColumn);
            }

            /// <summary>
            /// Sets the comments null.
            /// </summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetCommentsNull() {
                this[this.tabletbl_A1C.CommentsColumn] = global::System.Convert.DBNull;
            }
        }

        /// <summary>
        /// Row event argument class
        /// Implements the <see cref="System.EventArgs" />
        /// </summary>
        /// <seealso cref="System.EventArgs" />
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public class tbl_A1CRowChangeEvent : global::System.EventArgs {

            /// <summary>
            /// The event row
            /// </summary>
            private tbl_A1CRow eventRow;

            /// <summary>
            /// The event action
            /// </summary>
            private global::System.Data.DataRowAction eventAction;

            /// <summary>
            /// Initializes a new instance of the <see cref="tbl_A1CRowChangeEvent"/> class.
            /// </summary>
            /// <param name="row">The row.</param>
            /// <param name="action">The action.</param>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public tbl_A1CRowChangeEvent(tbl_A1CRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }

            /// <summary>
            /// Gets the row.
            /// </summary>
            /// <value>The row.</value>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public tbl_A1CRow Row {
                get {
                    return this.eventRow;
                }
            }

            /// <summary>
            /// Gets the action.
            /// </summary>
            /// <value>The action.</value>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
namespace A1CDesk.DB_103045_a1cdbDataSetTableAdapters {


    /// <summary>
    /// Represents the connection and commands used to retrieve and save data.
    /// Implements the <see cref="System.ComponentModel.Component" />
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class tbl_A1CTableAdapter : global::System.ComponentModel.Component {

        /// <summary>
        /// The adapter
        /// </summary>
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;

        /// <summary>
        /// The connection
        /// </summary>
        private global::System.Data.SqlClient.SqlConnection _connection;

        /// <summary>
        /// The transaction
        /// </summary>
        private global::System.Data.SqlClient.SqlTransaction _transaction;

        /// <summary>
        /// The command collection
        /// </summary>
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;

        /// <summary>
        /// The clear before fill
        /// </summary>
        private bool _clearBeforeFill;

        /// <summary>
        /// Initializes a new instance of the <see cref="tbl_A1CTableAdapter"/> class.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public tbl_A1CTableAdapter() {
            this.ClearBeforeFill = true;
        }

        /// <summary>
        /// Gets the adapter.
        /// </summary>
        /// <value>The adapter.</value>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }

        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>The connection.</value>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets the transaction.
        /// </summary>
        /// <value>The transaction.</value>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }

        /// <summary>
        /// Gets the command collection.
        /// </summary>
        /// <value>The command collection.</value>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [clear before fill].
        /// </summary>
        /// <value><c>true</c> if [clear before fill]; otherwise, <c>false</c>.</value>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }

        /// <summary>
        /// Initializes the adapter.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "tbl_A1C";
            tableMapping.ColumnMappings.Add("Id", "Id");
            tableMapping.ColumnMappings.Add("userID", "userID");
            tableMapping.ColumnMappings.Add("Reading_Date", "Reading_Date");
            tableMapping.ColumnMappings.Add("Reading_TOD", "Reading_TOD");
            tableMapping.ColumnMappings.Add("Reading_Value", "Reading_Value");
            tableMapping.ColumnMappings.Add("Comments", "Comments");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[tbl_A1C] WHERE (([Id] = @Original_Id) AND ([userID] = @Origina" +
                "l_userID) AND ([Reading_Date] = @Original_Reading_Date) AND ([Reading_TOD] = @Or" +
                "iginal_Reading_TOD) AND ([Reading_Value] = @Original_Reading_Value))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_userID", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "userID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Reading_Date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Reading_Date", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Reading_TOD", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Reading_TOD", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Reading_Value", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Reading_Value", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = @"INSERT INTO [dbo].[tbl_A1C] ([userID], [Reading_Date], [Reading_TOD], [Reading_Value], [Comments]) VALUES (@userID, @Reading_Date, @Reading_TOD, @Reading_Value, @Comments);
SELECT Id, userID, Reading_Date, Reading_TOD, Reading_Value, Comments FROM tbl_A1C WHERE (Id = SCOPE_IDENTITY())";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@userID", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "userID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Reading_Date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Reading_Date", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Reading_TOD", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Reading_TOD", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Reading_Value", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Reading_Value", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Comments", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Comments", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[tbl_A1C] SET [userID] = @userID, [Reading_Date] = @Reading_Date, [Reading_TOD] = @Reading_TOD, [Reading_Value] = @Reading_Value, [Comments] = @Comments WHERE (([Id] = @Original_Id) AND ([userID] = @Original_userID) AND ([Reading_Date] = @Original_Reading_Date) AND ([Reading_TOD] = @Original_Reading_TOD) AND ([Reading_Value] = @Original_Reading_Value));
SELECT Id, userID, Reading_Date, Reading_TOD, Reading_Value, Comments FROM tbl_A1C WHERE (Id = @Id)";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@userID", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "userID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Reading_Date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Reading_Date", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Reading_TOD", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Reading_TOD", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Reading_Value", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Reading_Value", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Comments", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Comments", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_userID", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "userID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Reading_Date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Reading_Date", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Reading_TOD", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Reading_TOD", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Reading_Value", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Reading_Value", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Id", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }

        /// <summary>
        /// Initializes the connection.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::A1CDesk.Properties.Settings.Default.DB_103045_a1cdbConnectionString;
        }

        /// <summary>
        /// Initializes the command collection.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT Id, userID, Reading_Date, Reading_TOD, Reading_Value, Comments FROM dbo.tb" +
                "l_A1C";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }

        /// <summary>
        /// Fills the specified data table.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <returns>System.Int32.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(DB_103045_a1cdbDataSet.tbl_A1CDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns>DB_103045_a1cdbDataSet.tbl_A1CDataTable.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual DB_103045_a1cdbDataSet.tbl_A1CDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            DB_103045_a1cdbDataSet.tbl_A1CDataTable dataTable = new DB_103045_a1cdbDataSet.tbl_A1CDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        /// <summary>
        /// Updates the specified data table.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <returns>System.Int32.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(DB_103045_a1cdbDataSet.tbl_A1CDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }

        /// <summary>
        /// Updates the specified data set.
        /// </summary>
        /// <param name="dataSet">The data set.</param>
        /// <returns>System.Int32.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(DB_103045_a1cdbDataSet dataSet) {
            return this.Adapter.Update(dataSet, "tbl_A1C");
        }

        /// <summary>
        /// Updates the specified data row.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <returns>System.Int32.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }

        /// <summary>
        /// Updates the specified data rows.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        /// <returns>System.Int32.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }

        /// <summary>
        /// Deletes the specified original identifier.
        /// </summary>
        /// <param name="Original_Id">The original identifier.</param>
        /// <param name="Original_userID">The original user identifier.</param>
        /// <param name="Original_Reading_Date">The original reading date.</param>
        /// <param name="Original_Reading_TOD">The original reading tod.</param>
        /// <param name="Original_Reading_Value">The original reading value.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// Original_userID
        /// or
        /// Original_Reading_TOD
        /// </exception>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_Id, string Original_userID, System.DateTime Original_Reading_Date, string Original_Reading_TOD, int Original_Reading_Value) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_Id));
            if ((Original_userID == null)) {
                throw new global::System.ArgumentNullException("Original_userID");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((string)(Original_userID));
            }
            this.Adapter.DeleteCommand.Parameters[2].Value = ((System.DateTime)(Original_Reading_Date));
            if ((Original_Reading_TOD == null)) {
                throw new global::System.ArgumentNullException("Original_Reading_TOD");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((string)(Original_Reading_TOD));
            }
            this.Adapter.DeleteCommand.Parameters[4].Value = ((int)(Original_Reading_Value));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }

        /// <summary>
        /// Inserts the specified user identifier.
        /// </summary>
        /// <param name="userID">The user identifier.</param>
        /// <param name="Reading_Date">The reading date.</param>
        /// <param name="Reading_TOD">The reading tod.</param>
        /// <param name="Reading_Value">The reading value.</param>
        /// <param name="Comments">The comments.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// userID
        /// or
        /// Reading_TOD
        /// </exception>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string userID, System.DateTime Reading_Date, string Reading_TOD, int Reading_Value, string Comments) {
            if ((userID == null)) {
                throw new global::System.ArgumentNullException("userID");
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(userID));
            }
            this.Adapter.InsertCommand.Parameters[1].Value = ((System.DateTime)(Reading_Date));
            if ((Reading_TOD == null)) {
                throw new global::System.ArgumentNullException("Reading_TOD");
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(Reading_TOD));
            }
            this.Adapter.InsertCommand.Parameters[3].Value = ((int)(Reading_Value));
            if ((Comments == null)) {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[4].Value = ((string)(Comments));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }

        /// <summary>
        /// Updates the specified user identifier.
        /// </summary>
        /// <param name="userID">The user identifier.</param>
        /// <param name="Reading_Date">The reading date.</param>
        /// <param name="Reading_TOD">The reading tod.</param>
        /// <param name="Reading_Value">The reading value.</param>
        /// <param name="Comments">The comments.</param>
        /// <param name="Original_Id">The original identifier.</param>
        /// <param name="Original_userID">The original user identifier.</param>
        /// <param name="Original_Reading_Date">The original reading date.</param>
        /// <param name="Original_Reading_TOD">The original reading tod.</param>
        /// <param name="Original_Reading_Value">The original reading value.</param>
        /// <param name="Id">The identifier.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// userID
        /// or
        /// Reading_TOD
        /// or
        /// Original_userID
        /// or
        /// Original_Reading_TOD
        /// </exception>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string userID, System.DateTime Reading_Date, string Reading_TOD, int Reading_Value, string Comments, int Original_Id, string Original_userID, System.DateTime Original_Reading_Date, string Original_Reading_TOD, int Original_Reading_Value, int Id) {
            if ((userID == null)) {
                throw new global::System.ArgumentNullException("userID");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(userID));
            }
            this.Adapter.UpdateCommand.Parameters[1].Value = ((System.DateTime)(Reading_Date));
            if ((Reading_TOD == null)) {
                throw new global::System.ArgumentNullException("Reading_TOD");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(Reading_TOD));
            }
            this.Adapter.UpdateCommand.Parameters[3].Value = ((int)(Reading_Value));
            if ((Comments == null)) {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((string)(Comments));
            }
            this.Adapter.UpdateCommand.Parameters[5].Value = ((int)(Original_Id));
            if ((Original_userID == null)) {
                throw new global::System.ArgumentNullException("Original_userID");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((string)(Original_userID));
            }
            this.Adapter.UpdateCommand.Parameters[7].Value = ((System.DateTime)(Original_Reading_Date));
            if ((Original_Reading_TOD == null)) {
                throw new global::System.ArgumentNullException("Original_Reading_TOD");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((string)(Original_Reading_TOD));
            }
            this.Adapter.UpdateCommand.Parameters[9].Value = ((int)(Original_Reading_Value));
            this.Adapter.UpdateCommand.Parameters[10].Value = ((int)(Id));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }

        /// <summary>
        /// Updates the specified user identifier.
        /// </summary>
        /// <param name="userID">The user identifier.</param>
        /// <param name="Reading_Date">The reading date.</param>
        /// <param name="Reading_TOD">The reading tod.</param>
        /// <param name="Reading_Value">The reading value.</param>
        /// <param name="Comments">The comments.</param>
        /// <param name="Original_Id">The original identifier.</param>
        /// <param name="Original_userID">The original user identifier.</param>
        /// <param name="Original_Reading_Date">The original reading date.</param>
        /// <param name="Original_Reading_TOD">The original reading tod.</param>
        /// <param name="Original_Reading_Value">The original reading value.</param>
        /// <returns>System.Int32.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string userID, System.DateTime Reading_Date, string Reading_TOD, int Reading_Value, string Comments, int Original_Id, string Original_userID, System.DateTime Original_Reading_Date, string Original_Reading_TOD, int Original_Reading_Value) {
            return this.Update(userID, Reading_Date, Reading_TOD, Reading_Value, Comments, Original_Id, Original_userID, Original_Reading_Date, Original_Reading_TOD, Original_Reading_Value, Original_Id);
        }
    }

    /// <summary>
    /// TableAdapterManager is used to coordinate TableAdapters in the dataset to enable Hierarchical Update scenarios
    /// Implements the <see cref="System.ComponentModel.Component" />
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSD" +
        "esigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapterManager")]
    public partial class TableAdapterManager : global::System.ComponentModel.Component {

        /// <summary>
        /// The update order
        /// </summary>
        private UpdateOrderOption _updateOrder;

        /// <summary>
        /// The table a1 c table adapter
        /// </summary>
        private tbl_A1CTableAdapter _tbl_A1CTableAdapter;

        /// <summary>
        /// The backup data set before update
        /// </summary>
        private bool _backupDataSetBeforeUpdate;

        /// <summary>
        /// The connection
        /// </summary>
        private global::System.Data.IDbConnection _connection;

        /// <summary>
        /// Gets or sets the update order.
        /// </summary>
        /// <value>The update order.</value>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public UpdateOrderOption UpdateOrder {
            get {
                return this._updateOrder;
            }
            set {
                this._updateOrder = value;
            }
        }

        /// <summary>
        /// Gets or sets the table a1 c table adapter.
        /// </summary>
        /// <value>The table a1 c table adapter.</value>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public tbl_A1CTableAdapter tbl_A1CTableAdapter {
            get {
                return this._tbl_A1CTableAdapter;
            }
            set {
                this._tbl_A1CTableAdapter = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [backup data set before update].
        /// </summary>
        /// <value><c>true</c> if [backup data set before update]; otherwise, <c>false</c>.</value>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public bool BackupDataSetBeforeUpdate {
            get {
                return this._backupDataSetBeforeUpdate;
            }
            set {
                this._backupDataSetBeforeUpdate = value;
            }
        }

        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>The connection.</value>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public global::System.Data.IDbConnection Connection {
            get {
                if ((this._connection != null)) {
                    return this._connection;
                }
                if (((this._tbl_A1CTableAdapter != null) 
                            && (this._tbl_A1CTableAdapter.Connection != null))) {
                    return this._tbl_A1CTableAdapter.Connection;
                }
                return null;
            }
            set {
                this._connection = value;
            }
        }

        /// <summary>
        /// Gets the table adapter instance count.
        /// </summary>
        /// <value>The table adapter instance count.</value>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public int TableAdapterInstanceCount {
            get {
                int count = 0;
                if ((this._tbl_A1CTableAdapter != null)) {
                    count = (count + 1);
                }
                return count;
            }
        }

        /// <summary>
        /// Update rows in top-down order.
        /// </summary>
        /// <param name="dataSet">The data set.</param>
        /// <param name="allChangedRows">All changed rows.</param>
        /// <param name="allAddedRows">All added rows.</param>
        /// <returns>System.Int32.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private int UpdateUpdatedRows(DB_103045_a1cdbDataSet dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            int result = 0;
            if ((this._tbl_A1CTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.tbl_A1C.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._tbl_A1CTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            return result;
        }

        /// <summary>
        /// Insert rows in top-down order.
        /// </summary>
        /// <param name="dataSet">The data set.</param>
        /// <param name="allAddedRows">All added rows.</param>
        /// <returns>System.Int32.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private int UpdateInsertedRows(DB_103045_a1cdbDataSet dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            int result = 0;
            if ((this._tbl_A1CTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.tbl_A1C.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._tbl_A1CTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            return result;
        }

        /// <summary>
        /// Delete rows in bottom-up order.
        /// </summary>
        /// <param name="dataSet">The data set.</param>
        /// <param name="allChangedRows">All changed rows.</param>
        /// <returns>System.Int32.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private int UpdateDeletedRows(DB_103045_a1cdbDataSet dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows) {
            int result = 0;
            if ((this._tbl_A1CTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.tbl_A1C.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._tbl_A1CTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            return result;
        }

        /// <summary>
        /// Remove inserted rows that become updated rows after calling TableAdapter.Update(inserted rows) first
        /// </summary>
        /// <param name="updatedRows">The updated rows.</param>
        /// <param name="allAddedRows">All added rows.</param>
        /// <returns>System.Data.DataRow[].</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private global::System.Data.DataRow[] GetRealUpdatedRows(global::System.Data.DataRow[] updatedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            if (((updatedRows == null) 
                        || (updatedRows.Length < 1))) {
                return updatedRows;
            }
            if (((allAddedRows == null) 
                        || (allAddedRows.Count < 1))) {
                return updatedRows;
            }
            global::System.Collections.Generic.List<global::System.Data.DataRow> realUpdatedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            for (int i = 0; (i < updatedRows.Length); i = (i + 1)) {
                global::System.Data.DataRow row = updatedRows[i];
                if ((allAddedRows.Contains(row) == false)) {
                    realUpdatedRows.Add(row);
                }
            }
            return realUpdatedRows.ToArray();
        }

        /// <summary>
        /// Update all changes to the dataset.
        /// </summary>
        /// <param name="dataSet">The data set.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="System.ArgumentNullException">dataSet</exception>
        /// <exception cref="System.ArgumentException">All TableAdapters managed by a TableAdapterManager must use the same connection s" +
        ///                         "tring.</exception>
        /// <exception cref="System.ApplicationException">
        /// TableAdapterManager contains no connection information. Set each TableAdapterMana" +
        ///                         "ger TableAdapter property to a valid TableAdapter instance.
        /// or
        /// The transaction cannot begin. The current data connection does not support transa" +
        ///                         "ctions or the current state is not allowing the transaction to begin.
        /// </exception>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public virtual int UpdateAll(DB_103045_a1cdbDataSet dataSet) {
            if ((dataSet == null)) {
                throw new global::System.ArgumentNullException("dataSet");
            }
            if ((dataSet.HasChanges() == false)) {
                return 0;
            }
            if (((this._tbl_A1CTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._tbl_A1CTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            global::System.Data.IDbConnection workConnection = this.Connection;
            if ((workConnection == null)) {
                throw new global::System.ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterMana" +
                        "ger TableAdapter property to a valid TableAdapter instance.");
            }
            bool workConnOpened = false;
            if (((workConnection.State & global::System.Data.ConnectionState.Broken) 
                        == global::System.Data.ConnectionState.Broken)) {
                workConnection.Close();
            }
            if ((workConnection.State == global::System.Data.ConnectionState.Closed)) {
                workConnection.Open();
                workConnOpened = true;
            }
            global::System.Data.IDbTransaction workTransaction = workConnection.BeginTransaction();
            if ((workTransaction == null)) {
                throw new global::System.ApplicationException("The transaction cannot begin. The current data connection does not support transa" +
                        "ctions or the current state is not allowing the transaction to begin.");
            }
            global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter> adaptersWithAcceptChangesDuringUpdate = new global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter>();
            global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection> revertConnections = new global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection>();
            int result = 0;
            global::System.Data.DataSet backupDataSet = null;
            if (this.BackupDataSetBeforeUpdate) {
                backupDataSet = new global::System.Data.DataSet();
                backupDataSet.Merge(dataSet);
            }
            try {
                // ---- Prepare for update -----------
                //
                if ((this._tbl_A1CTableAdapter != null)) {
                    revertConnections.Add(this._tbl_A1CTableAdapter, this._tbl_A1CTableAdapter.Connection);
                    this._tbl_A1CTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                    this._tbl_A1CTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                    if (this._tbl_A1CTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._tbl_A1CTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._tbl_A1CTableAdapter.Adapter);
                    }
                }
                // 
                //---- Perform updates -----------
                //
                if ((this.UpdateOrder == UpdateOrderOption.UpdateInsertDelete)) {
                    result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                    result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                }
                else {
                    result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                    result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                }
                result = (result + this.UpdateDeletedRows(dataSet, allChangedRows));
                // 
                //---- Commit updates -----------
                //
                workTransaction.Commit();
                if ((0 < allAddedRows.Count)) {
                    global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                    allAddedRows.CopyTo(rows);
                    for (int i = 0; (i < rows.Length); i = (i + 1)) {
                        global::System.Data.DataRow row = rows[i];
                        row.AcceptChanges();
                    }
                }
                if ((0 < allChangedRows.Count)) {
                    global::System.Data.DataRow[] rows = new System.Data.DataRow[allChangedRows.Count];
                    allChangedRows.CopyTo(rows);
                    for (int i = 0; (i < rows.Length); i = (i + 1)) {
                        global::System.Data.DataRow row = rows[i];
                        row.AcceptChanges();
                    }
                }
            }
            catch (global::System.Exception ex) {
                workTransaction.Rollback();
                // ---- Restore the dataset -----------
                if (this.BackupDataSetBeforeUpdate) {
                    global::System.Diagnostics.Debug.Assert((backupDataSet != null));
                    dataSet.Clear();
                    dataSet.Merge(backupDataSet);
                }
                else {
                    if ((0 < allAddedRows.Count)) {
                        global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                        allAddedRows.CopyTo(rows);
                        for (int i = 0; (i < rows.Length); i = (i + 1)) {
                            global::System.Data.DataRow row = rows[i];
                            row.AcceptChanges();
                            row.SetAdded();
                        }
                    }
                }
                throw ex;
            }
            finally {
                if (workConnOpened) {
                    workConnection.Close();
                }
                if ((this._tbl_A1CTableAdapter != null)) {
                    this._tbl_A1CTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._tbl_A1CTableAdapter]));
                    this._tbl_A1CTableAdapter.Transaction = null;
                }
                if ((0 < adaptersWithAcceptChangesDuringUpdate.Count)) {
                    global::System.Data.Common.DataAdapter[] adapters = new System.Data.Common.DataAdapter[adaptersWithAcceptChangesDuringUpdate.Count];
                    adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters);
                    for (int i = 0; (i < adapters.Length); i = (i + 1)) {
                        global::System.Data.Common.DataAdapter adapter = adapters[i];
                        adapter.AcceptChangesDuringUpdate = true;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Sorts the self reference rows.
        /// </summary>
        /// <param name="rows">The rows.</param>
        /// <param name="relation">The relation.</param>
        /// <param name="childFirst">if set to <c>true</c> [child first].</param>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected virtual void SortSelfReferenceRows(global::System.Data.DataRow[] rows, global::System.Data.DataRelation relation, bool childFirst) {
            global::System.Array.Sort<global::System.Data.DataRow>(rows, new SelfReferenceComparer(relation, childFirst));
        }

        /// <summary>
        /// Matches the table adapter connection.
        /// </summary>
        /// <param name="inputConnection">The input connection.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected virtual bool MatchTableAdapterConnection(global::System.Data.IDbConnection inputConnection) {
            if ((this._connection != null)) {
                return true;
            }
            if (((this.Connection == null) 
                        || (inputConnection == null))) {
                return true;
            }
            if (string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, global::System.StringComparison.Ordinal)) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update Order Option
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public enum UpdateOrderOption {

            /// <summary>
            /// The insert update delete
            /// </summary>
            InsertUpdateDelete = 0,

            /// <summary>
            /// The update insert delete
            /// </summary>
            UpdateInsertDelete = 1,
        }

        /// <summary>
        /// Used to sort self-referenced table's rows
        /// Implements the <see cref="System.Collections.Generic.IComparer{System.Data.DataRow}" />
        /// </summary>
        /// <seealso cref="System.Collections.Generic.IComparer{System.Data.DataRow}" />
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private class SelfReferenceComparer : object, global::System.Collections.Generic.IComparer<global::System.Data.DataRow> {

            /// <summary>
            /// The relation
            /// </summary>
            private global::System.Data.DataRelation _relation;

            /// <summary>
            /// The child first
            /// </summary>
            private int _childFirst;

            /// <summary>
            /// Initializes a new instance of the <see cref="SelfReferenceComparer"/> class.
            /// </summary>
            /// <param name="relation">The relation.</param>
            /// <param name="childFirst">if set to <c>true</c> [child first].</param>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal SelfReferenceComparer(global::System.Data.DataRelation relation, bool childFirst) {
                this._relation = relation;
                if (childFirst) {
                    this._childFirst = -1;
                }
                else {
                    this._childFirst = 1;
                }
            }

            /// <summary>
            /// Gets the root.
            /// </summary>
            /// <param name="row">The row.</param>
            /// <param name="distance">The distance.</param>
            /// <returns>System.Data.DataRow.</returns>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private global::System.Data.DataRow GetRoot(global::System.Data.DataRow row, out int distance) {
                global::System.Diagnostics.Debug.Assert((row != null));
                global::System.Data.DataRow root = row;
                distance = 0;

                global::System.Collections.Generic.IDictionary<global::System.Data.DataRow, global::System.Data.DataRow> traversedRows = new global::System.Collections.Generic.Dictionary<global::System.Data.DataRow, global::System.Data.DataRow>();
                traversedRows[row] = row;

                global::System.Data.DataRow parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                for (
                ; ((parent != null) 
                            && (traversedRows.ContainsKey(parent) == false)); 
                ) {
                    distance = (distance + 1);
                    root = parent;
                    traversedRows[parent] = parent;
                    parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                }

                if ((distance == 0)) {
                    traversedRows.Clear();
                    traversedRows[row] = row;
                    parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                    for (
                    ; ((parent != null) 
                                && (traversedRows.ContainsKey(parent) == false)); 
                    ) {
                        distance = (distance + 1);
                        root = parent;
                        traversedRows[parent] = parent;
                        parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                    }
                }

                return root;
            }

            /// <summary>
            /// Compares the specified row1.
            /// </summary>
            /// <param name="row1">The row1.</param>
            /// <param name="row2">The row2.</param>
            /// <returns>System.Int32.</returns>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Compare(global::System.Data.DataRow row1, global::System.Data.DataRow row2) {
                if (object.ReferenceEquals(row1, row2)) {
                    return 0;
                }
                if ((row1 == null)) {
                    return -1;
                }
                if ((row2 == null)) {
                    return 1;
                }

                int distance1 = 0;
                global::System.Data.DataRow root1 = this.GetRoot(row1, out distance1);

                int distance2 = 0;
                global::System.Data.DataRow root2 = this.GetRoot(row2, out distance2);

                if (object.ReferenceEquals(root1, root2)) {
                    return (this._childFirst * distance1.CompareTo(distance2));
                }
                else {
                    global::System.Diagnostics.Debug.Assert(((root1.Table != null) 
                                    && (root2.Table != null)));
                    if ((root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2))) {
                        return -1;
                    }
                    else {
                        return 1;
                    }
                }
            }
        }
    }
}

#pragma warning restore 1591