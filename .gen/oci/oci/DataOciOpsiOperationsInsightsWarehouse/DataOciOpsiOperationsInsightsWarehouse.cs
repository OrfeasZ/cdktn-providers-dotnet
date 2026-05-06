using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOpsiOperationsInsightsWarehouse
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_operations_insights_warehouse oci_opsi_operations_insights_warehouse}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOpsiOperationsInsightsWarehouse.DataOciOpsiOperationsInsightsWarehouse), fullyQualifiedName: "oci.dataOciOpsiOperationsInsightsWarehouse.DataOciOpsiOperationsInsightsWarehouse", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOpsiOperationsInsightsWarehouse.DataOciOpsiOperationsInsightsWarehouseConfig\"}}]")]
    public class DataOciOpsiOperationsInsightsWarehouse : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_operations_insights_warehouse oci_opsi_operations_insights_warehouse} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOpsiOperationsInsightsWarehouse(Constructs.Construct scope, string id, oci.DataOciOpsiOperationsInsightsWarehouse.IDataOciOpsiOperationsInsightsWarehouseConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOpsiOperationsInsightsWarehouse.IDataOciOpsiOperationsInsightsWarehouseConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiOperationsInsightsWarehouse(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiOperationsInsightsWarehouse(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOpsiOperationsInsightsWarehouse resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOpsiOperationsInsightsWarehouse to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOpsiOperationsInsightsWarehouse that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOpsiOperationsInsightsWarehouse to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOpsiOperationsInsightsWarehouse to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_operations_insights_warehouse#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOpsiOperationsInsightsWarehouse that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOpsiOperationsInsightsWarehouse to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOpsiOperationsInsightsWarehouse.DataOciOpsiOperationsInsightsWarehouse), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciOpsiOperationsInsightsWarehouse.DataOciOpsiOperationsInsightsWarehouse))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpuAllocated", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuAllocated
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cpuUsed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuUsed
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dynamicGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DynamicGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operationsInsightsTenancyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationsInsightsTenancyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageAllocatedInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageAllocatedInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "storageUsedInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageUsedInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastWalletRotated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastWalletRotated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "operationsInsightsWarehouseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperationsInsightsWarehouseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "operationsInsightsWarehouseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationsInsightsWarehouseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
