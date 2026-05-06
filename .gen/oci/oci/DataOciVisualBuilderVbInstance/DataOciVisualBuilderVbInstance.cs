using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciVisualBuilderVbInstance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/visual_builder_vb_instance oci_visual_builder_vb_instance}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstance), fullyQualifiedName: "oci.dataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstanceConfig\"}}]")]
    public class DataOciVisualBuilderVbInstance : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/visual_builder_vb_instance oci_visual_builder_vb_instance} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciVisualBuilderVbInstance(Constructs.Construct scope, string id, oci.DataOciVisualBuilderVbInstance.IDataOciVisualBuilderVbInstanceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciVisualBuilderVbInstance.IDataOciVisualBuilderVbInstanceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciVisualBuilderVbInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciVisualBuilderVbInstance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciVisualBuilderVbInstance resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciVisualBuilderVbInstance to import.</param>
        /// <param name="importFromId">The id of the existing DataOciVisualBuilderVbInstance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciVisualBuilderVbInstance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciVisualBuilderVbInstance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/visual_builder_vb_instance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciVisualBuilderVbInstance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciVisualBuilderVbInstance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstance))!;

        [JsiiProperty(name: "alternateCustomEndpoints", typeJson: "{\"fqn\":\"oci.dataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstanceAlternateCustomEndpointsList\"}")]
        public virtual oci.DataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstanceAlternateCustomEndpointsList AlternateCustomEndpoints
        {
            get => GetInstanceProperty<oci.DataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstanceAlternateCustomEndpointsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "consumptionModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumptionModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customEndpoint", typeJson: "{\"fqn\":\"oci.dataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstanceCustomEndpointList\"}")]
        public virtual oci.DataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstanceCustomEndpointList CustomEndpoint
        {
            get => GetInstanceProperty<oci.DataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstanceCustomEndpointList>()!;
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

        [JsiiProperty(name: "idcsOpenId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsOpenId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isVisualBuilderEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsVisualBuilderEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "managementNatGatewayIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementNatGatewayIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementVcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementVcnId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkEndpointDetails", typeJson: "{\"fqn\":\"oci.dataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstanceNetworkEndpointDetailsList\"}")]
        public virtual oci.DataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstanceNetworkEndpointDetailsList NetworkEndpointDetails
        {
            get => GetInstanceProperty<oci.DataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstanceNetworkEndpointDetailsList>()!;
        }

        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "serviceNatGatewayIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceNatGatewayIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceVcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceVcnId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stateMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StateMessage
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "vbInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VbInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "vbInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VbInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
