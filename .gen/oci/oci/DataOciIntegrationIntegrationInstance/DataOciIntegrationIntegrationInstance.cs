using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIntegrationIntegrationInstance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/integration_integration_instance oci_integration_integration_instance}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstance), fullyQualifiedName: "oci.dataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceConfig\"}}]")]
    public class DataOciIntegrationIntegrationInstance : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/integration_integration_instance oci_integration_integration_instance} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciIntegrationIntegrationInstance(Constructs.Construct scope, string id, oci.DataOciIntegrationIntegrationInstance.IDataOciIntegrationIntegrationInstanceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciIntegrationIntegrationInstance.IDataOciIntegrationIntegrationInstanceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIntegrationIntegrationInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIntegrationIntegrationInstance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciIntegrationIntegrationInstance resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciIntegrationIntegrationInstance to import.</param>
        /// <param name="importFromId">The id of the existing DataOciIntegrationIntegrationInstance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciIntegrationIntegrationInstance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciIntegrationIntegrationInstance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/integration_integration_instance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciIntegrationIntegrationInstance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciIntegrationIntegrationInstance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstance))!;

        [JsiiProperty(name: "alternateCustomEndpoints", typeJson: "{\"fqn\":\"oci.dataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceAlternateCustomEndpointsList\"}")]
        public virtual oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceAlternateCustomEndpointsList AlternateCustomEndpoints
        {
            get => GetInstanceProperty<oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceAlternateCustomEndpointsList>()!;
        }

        [JsiiProperty(name: "attachments", typeJson: "{\"fqn\":\"oci.dataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceAttachmentsList\"}")]
        public virtual oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceAttachmentsList Attachments
        {
            get => GetInstanceProperty<oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceAttachmentsList>()!;
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

        [JsiiProperty(name: "customEndpoint", typeJson: "{\"fqn\":\"oci.dataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceCustomEndpointList\"}")]
        public virtual oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceCustomEndpointList CustomEndpoint
        {
            get => GetInstanceProperty<oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceCustomEndpointList>()!;
        }

        [JsiiProperty(name: "dataRetentionPeriod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataRetentionPeriod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "disasterRecoveryDetails", typeJson: "{\"fqn\":\"oci.dataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceDisasterRecoveryDetailsList\"}")]
        public virtual oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceDisasterRecoveryDetailsList DisasterRecoveryDetails
        {
            get => GetInstanceProperty<oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceDisasterRecoveryDetailsList>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enableProcessAutomationTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EnableProcessAutomationTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "extendDataRetentionTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExtendDataRetentionTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "failoverTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailoverTrigger
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "idcsAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsInfo", typeJson: "{\"fqn\":\"oci.dataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceIdcsInfoList\"}")]
        public virtual oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceIdcsInfoList IdcsInfo
        {
            get => GetInstanceProperty<oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceIdcsInfoList>()!;
        }

        [JsiiProperty(name: "instanceDesignTimeUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceDesignTimeUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "integrationInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IntegrationInstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isByol", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsByol
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDisasterRecoveryEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDisasterRecoveryEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isFileServerEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFileServerEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isVisualBuilderEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsVisualBuilderEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "messagePacks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MessagePacks
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "networkEndpointDetails", typeJson: "{\"fqn\":\"oci.dataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceNetworkEndpointDetailsList\"}")]
        public virtual oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceNetworkEndpointDetailsList NetworkEndpointDetails
        {
            get => GetInstanceProperty<oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstanceNetworkEndpointDetailsList>()!;
        }

        [JsiiProperty(name: "privateEndpointOutboundConnection", typeJson: "{\"fqn\":\"oci.dataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstancePrivateEndpointOutboundConnectionList\"}")]
        public virtual oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstancePrivateEndpointOutboundConnectionList PrivateEndpointOutboundConnection
        {
            get => GetInstanceProperty<oci.DataOciIntegrationIntegrationInstance.DataOciIntegrationIntegrationInstancePrivateEndpointOutboundConnectionList>()!;
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SecurityAttributes
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
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
        [JsiiProperty(name: "integrationInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IntegrationInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "integrationInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IntegrationInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
