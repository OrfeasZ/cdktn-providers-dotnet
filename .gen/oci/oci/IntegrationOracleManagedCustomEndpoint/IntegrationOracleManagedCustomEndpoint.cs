using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IntegrationOracleManagedCustomEndpoint
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_oracle_managed_custom_endpoint oci_integration_oracle_managed_custom_endpoint}.</summary>
    [JsiiClass(nativeType: typeof(oci.IntegrationOracleManagedCustomEndpoint.IntegrationOracleManagedCustomEndpoint), fullyQualifiedName: "oci.integrationOracleManagedCustomEndpoint.IntegrationOracleManagedCustomEndpoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.integrationOracleManagedCustomEndpoint.IntegrationOracleManagedCustomEndpointConfig\"}}]")]
    public class IntegrationOracleManagedCustomEndpoint : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_oracle_managed_custom_endpoint oci_integration_oracle_managed_custom_endpoint} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IntegrationOracleManagedCustomEndpoint(Constructs.Construct scope, string id, oci.IntegrationOracleManagedCustomEndpoint.IIntegrationOracleManagedCustomEndpointConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.IntegrationOracleManagedCustomEndpoint.IIntegrationOracleManagedCustomEndpointConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IntegrationOracleManagedCustomEndpoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IntegrationOracleManagedCustomEndpoint(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IntegrationOracleManagedCustomEndpoint resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IntegrationOracleManagedCustomEndpoint to import.</param>
        /// <param name="importFromId">The id of the existing IntegrationOracleManagedCustomEndpoint that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IntegrationOracleManagedCustomEndpoint to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IntegrationOracleManagedCustomEndpoint to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_oracle_managed_custom_endpoint#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IntegrationOracleManagedCustomEndpoint that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IntegrationOracleManagedCustomEndpoint to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.IntegrationOracleManagedCustomEndpoint.IntegrationOracleManagedCustomEndpoint), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.integrationOracleManagedCustomEndpoint.IntegrationOracleManagedCustomEndpointTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.IntegrationOracleManagedCustomEndpoint.IIntegrationOracleManagedCustomEndpointTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IntegrationOracleManagedCustomEndpoint.IIntegrationOracleManagedCustomEndpointTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDnsType")]
        public virtual void ResetDnsType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsZoneName")]
        public virtual void ResetDnsZoneName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedType")]
        public virtual void ResetManagedType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(oci.IntegrationOracleManagedCustomEndpoint.IntegrationOracleManagedCustomEndpoint))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.integrationOracleManagedCustomEndpoint.IntegrationOracleManagedCustomEndpointTimeoutsOutputReference\"}")]
        public virtual oci.IntegrationOracleManagedCustomEndpoint.IntegrationOracleManagedCustomEndpointTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.IntegrationOracleManagedCustomEndpoint.IntegrationOracleManagedCustomEndpointTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DnsTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsZoneNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DnsZoneNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "integrationInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IntegrationInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.integrationOracleManagedCustomEndpoint.IntegrationOracleManagedCustomEndpointTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "dnsType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dnsZoneName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsZoneName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "integrationInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IntegrationInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
