using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_operations_insights_warehouse_resource_usage_summary oci_opsi_operations_insights_warehouse_resource_usage_summary}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary.DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary), fullyQualifiedName: "oci.dataOciOpsiOperationsInsightsWarehouseResourceUsageSummary.DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOpsiOperationsInsightsWarehouseResourceUsageSummary.DataOciOpsiOperationsInsightsWarehouseResourceUsageSummaryConfig\"}}]")]
    public class DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_operations_insights_warehouse_resource_usage_summary oci_opsi_operations_insights_warehouse_resource_usage_summary} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary(Constructs.Construct scope, string id, oci.DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary.IDataOciOpsiOperationsInsightsWarehouseResourceUsageSummaryConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary.IDataOciOpsiOperationsInsightsWarehouseResourceUsageSummaryConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_operations_insights_warehouse_resource_usage_summary#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary.DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary.DataOciOpsiOperationsInsightsWarehouseResourceUsageSummary))!;

        [JsiiProperty(name: "cpuUsed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuUsed
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageUsedInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageUsedInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operationsInsightsWarehouseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperationsInsightsWarehouseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "operationsInsightsWarehouseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationsInsightsWarehouseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
