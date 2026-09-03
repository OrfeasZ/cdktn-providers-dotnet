using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOcvpManagementAppliance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/ocvp_management_appliance oci_ocvp_management_appliance}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOcvpManagementAppliance.DataOciOcvpManagementAppliance), fullyQualifiedName: "oci.dataOciOcvpManagementAppliance.DataOciOcvpManagementAppliance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOcvpManagementAppliance.DataOciOcvpManagementApplianceConfig\"}}]")]
    public class DataOciOcvpManagementAppliance : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/ocvp_management_appliance oci_ocvp_management_appliance} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOcvpManagementAppliance(Constructs.Construct scope, string id, oci.DataOciOcvpManagementAppliance.IDataOciOcvpManagementApplianceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOcvpManagementAppliance.IDataOciOcvpManagementApplianceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOcvpManagementAppliance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOcvpManagementAppliance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOcvpManagementAppliance resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOcvpManagementAppliance to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOcvpManagementAppliance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOcvpManagementAppliance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOcvpManagementAppliance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/ocvp_management_appliance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOcvpManagementAppliance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOcvpManagementAppliance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOcvpManagementAppliance.DataOciOcvpManagementAppliance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciOcvpManagementAppliance.DataOciOcvpManagementAppliance))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"oci.dataOciOcvpManagementAppliance.DataOciOcvpManagementApplianceConfigurationList\"}")]
        public virtual oci.DataOciOcvpManagementAppliance.DataOciOcvpManagementApplianceConfigurationList Configuration
        {
            get => GetInstanceProperty<oci.DataOciOcvpManagementAppliance.DataOciOcvpManagementApplianceConfigurationList>()!;
        }

        [JsiiProperty(name: "connections", typeJson: "{\"fqn\":\"oci.dataOciOcvpManagementAppliance.DataOciOcvpManagementApplianceConnectionsList\"}")]
        public virtual oci.DataOciOcvpManagementAppliance.DataOciOcvpManagementApplianceConnectionsList Connections
        {
            get => GetInstanceProperty<oci.DataOciOcvpManagementAppliance.DataOciOcvpManagementApplianceConnectionsList>()!;
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

        [JsiiProperty(name: "heartbeatConnectionStates", typeJson: "{\"fqn\":\"oci.dataOciOcvpManagementAppliance.DataOciOcvpManagementApplianceHeartbeatConnectionStatesList\"}")]
        public virtual oci.DataOciOcvpManagementAppliance.DataOciOcvpManagementApplianceHeartbeatConnectionStatesList HeartbeatConnectionStates
        {
            get => GetInstanceProperty<oci.DataOciOcvpManagementAppliance.DataOciOcvpManagementApplianceHeartbeatConnectionStatesList>()!;
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

        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementAgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pluginVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PluginVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicSshKeys", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicSshKeys
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sddcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SddcId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeConfigurationUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeConfigurationUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastHeartbeat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastHeartbeat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "managementApplianceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagementApplianceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "managementApplianceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementApplianceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
