using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreFastConnectProviderService
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_fast_connect_provider_service oci_core_fast_connect_provider_service}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCoreFastConnectProviderService.DataOciCoreFastConnectProviderService), fullyQualifiedName: "oci.dataOciCoreFastConnectProviderService.DataOciCoreFastConnectProviderService", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCoreFastConnectProviderService.DataOciCoreFastConnectProviderServiceConfig\"}}]")]
    public class DataOciCoreFastConnectProviderService : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_fast_connect_provider_service oci_core_fast_connect_provider_service} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCoreFastConnectProviderService(Constructs.Construct scope, string id, oci.DataOciCoreFastConnectProviderService.IDataOciCoreFastConnectProviderServiceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCoreFastConnectProviderService.IDataOciCoreFastConnectProviderServiceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreFastConnectProviderService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreFastConnectProviderService(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCoreFastConnectProviderService resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCoreFastConnectProviderService to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCoreFastConnectProviderService that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCoreFastConnectProviderService to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCoreFastConnectProviderService to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_fast_connect_provider_service#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCoreFastConnectProviderService that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCoreFastConnectProviderService to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCoreFastConnectProviderService.DataOciCoreFastConnectProviderService), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciCoreFastConnectProviderService.DataOciCoreFastConnectProviderService))!;

        [JsiiProperty(name: "bandwithShapeManagement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BandwithShapeManagement
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerAsnManagement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerAsnManagement
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privatePeeringBgpManagement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivatePeeringBgpManagement
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "providerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "providerServiceKeyManagement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderServiceKeyManagement
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "providerServiceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderServiceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicPeeringBgpManagement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicPeeringBgpManagement
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requiredTotalCrossConnects", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RequiredTotalCrossConnects
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "supportedVirtualCircuitTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedVirtualCircuitTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "providerServiceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProviderServiceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "providerServiceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderServiceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
