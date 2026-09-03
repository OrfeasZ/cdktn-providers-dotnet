using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGenerativeAiHostedApplication
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/generative_ai_hosted_application oci_generative_ai_hosted_application}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplication), fullyQualifiedName: "oci.dataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplication", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplicationConfig\"}}]")]
    public class DataOciGenerativeAiHostedApplication : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/generative_ai_hosted_application oci_generative_ai_hosted_application} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciGenerativeAiHostedApplication(Constructs.Construct scope, string id, oci.DataOciGenerativeAiHostedApplication.IDataOciGenerativeAiHostedApplicationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciGenerativeAiHostedApplication.IDataOciGenerativeAiHostedApplicationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGenerativeAiHostedApplication(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGenerativeAiHostedApplication(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciGenerativeAiHostedApplication resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciGenerativeAiHostedApplication to import.</param>
        /// <param name="importFromId">The id of the existing DataOciGenerativeAiHostedApplication that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciGenerativeAiHostedApplication to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciGenerativeAiHostedApplication to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/generative_ai_hosted_application#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciGenerativeAiHostedApplication that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciGenerativeAiHostedApplication to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplication), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplication))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "environmentVariables", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplicationEnvironmentVariablesList\"}")]
        public virtual oci.DataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplicationEnvironmentVariablesList EnvironmentVariables
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplicationEnvironmentVariablesList>()!;
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

        [JsiiProperty(name: "inboundAuthConfig", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplicationInboundAuthConfigList\"}")]
        public virtual oci.DataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplicationInboundAuthConfigList InboundAuthConfig
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplicationInboundAuthConfigList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkingConfig", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplicationNetworkingConfigList\"}")]
        public virtual oci.DataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplicationNetworkingConfigList NetworkingConfig
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplicationNetworkingConfigList>()!;
        }

        [JsiiProperty(name: "scalingConfig", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplicationScalingConfigList\"}")]
        public virtual oci.DataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplicationScalingConfigList ScalingConfig
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplicationScalingConfigList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageConfigs", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplicationStorageConfigsList\"}")]
        public virtual oci.DataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplicationStorageConfigsList StorageConfigs
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiHostedApplication.DataOciGenerativeAiHostedApplicationStorageConfigsList>()!;
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
        [JsiiProperty(name: "hostedApplicationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostedApplicationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "hostedApplicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostedApplicationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
