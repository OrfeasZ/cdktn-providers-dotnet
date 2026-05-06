using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VnMonitoringPathAnalysi
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi oci_vn_monitoring_path_analysi}.</summary>
    [JsiiClass(nativeType: typeof(oci.VnMonitoringPathAnalysi.VnMonitoringPathAnalysi), fullyQualifiedName: "oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysi", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiConfig\"}}]")]
    public class VnMonitoringPathAnalysi : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi oci_vn_monitoring_path_analysi} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VnMonitoringPathAnalysi(Constructs.Construct scope, string id, oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VnMonitoringPathAnalysi(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VnMonitoringPathAnalysi(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a VnMonitoringPathAnalysi resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VnMonitoringPathAnalysi to import.</param>
        /// <param name="importFromId">The id of the existing VnMonitoringPathAnalysi that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VnMonitoringPathAnalysi to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VnMonitoringPathAnalysi to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VnMonitoringPathAnalysi that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VnMonitoringPathAnalysi to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.VnMonitoringPathAnalysi.VnMonitoringPathAnalysi), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDestinationEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiDestinationEndpoint\"}}]")]
        public virtual void PutDestinationEndpoint(oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiDestinationEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiDestinationEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProtocolParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiProtocolParameters\"}}]")]
        public virtual void PutProtocolParameters(oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiProtocolParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiProtocolParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiQueryOptions\"}}]")]
        public virtual void PutQueryOptions(oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiQueryOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiQueryOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiSourceEndpoint\"}}]")]
        public virtual void PutSourceEndpoint(oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiSourceEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiSourceEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCacheControl")]
        public virtual void ResetCacheControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestinationEndpoint")]
        public virtual void ResetDestinationEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPathAnalyzerTestId")]
        public virtual void ResetPathAnalyzerTestId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocol")]
        public virtual void ResetProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocolParameters")]
        public virtual void ResetProtocolParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryOptions")]
        public virtual void ResetQueryOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceEndpoint")]
        public virtual void ResetSourceEndpoint()
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
        = GetStaticProperty<string>(typeof(oci.VnMonitoringPathAnalysi.VnMonitoringPathAnalysi))!;

        [JsiiProperty(name: "destinationEndpoint", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiDestinationEndpointOutputReference\"}")]
        public virtual oci.VnMonitoringPathAnalysi.VnMonitoringPathAnalysiDestinationEndpointOutputReference DestinationEndpoint
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalysi.VnMonitoringPathAnalysiDestinationEndpointOutputReference>()!;
        }

        [JsiiProperty(name: "protocolParameters", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiProtocolParametersOutputReference\"}")]
        public virtual oci.VnMonitoringPathAnalysi.VnMonitoringPathAnalysiProtocolParametersOutputReference ProtocolParameters
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalysi.VnMonitoringPathAnalysiProtocolParametersOutputReference>()!;
        }

        [JsiiProperty(name: "queryOptions", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiQueryOptionsOutputReference\"}")]
        public virtual oci.VnMonitoringPathAnalysi.VnMonitoringPathAnalysiQueryOptionsOutputReference QueryOptions
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalysi.VnMonitoringPathAnalysiQueryOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "sourceEndpoint", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiSourceEndpointOutputReference\"}")]
        public virtual oci.VnMonitoringPathAnalysi.VnMonitoringPathAnalysiSourceEndpointOutputReference SourceEndpoint
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalysi.VnMonitoringPathAnalysiSourceEndpointOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiTimeoutsOutputReference\"}")]
        public virtual oci.VnMonitoringPathAnalysi.VnMonitoringPathAnalysiTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalysi.VnMonitoringPathAnalysiTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheControlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CacheControlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationEndpointInput", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiDestinationEndpoint\"}", isOptional: true)]
        public virtual oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiDestinationEndpoint? DestinationEndpointInput
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiDestinationEndpoint?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathAnalyzerTestIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathAnalyzerTestIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ProtocolInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolParametersInput", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiProtocolParameters\"}", isOptional: true)]
        public virtual oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiProtocolParameters? ProtocolParametersInput
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiProtocolParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryOptionsInput", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiQueryOptions\"}", isOptional: true)]
        public virtual oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiQueryOptions? QueryOptionsInput
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiQueryOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceEndpointInput", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiSourceEndpoint\"}", isOptional: true)]
        public virtual oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiSourceEndpoint? SourceEndpointInput
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiSourceEndpoint?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cacheControl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CacheControl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
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

        [JsiiProperty(name: "pathAnalyzerTestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PathAnalyzerTestId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Protocol
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
