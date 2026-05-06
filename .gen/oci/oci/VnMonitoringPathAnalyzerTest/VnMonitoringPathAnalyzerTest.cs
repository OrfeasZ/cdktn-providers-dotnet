using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VnMonitoringPathAnalyzerTest
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test oci_vn_monitoring_path_analyzer_test}.</summary>
    [JsiiClass(nativeType: typeof(oci.VnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTest), fullyQualifiedName: "oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTest", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestConfig\"}}]")]
    public class VnMonitoringPathAnalyzerTest : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test oci_vn_monitoring_path_analyzer_test} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VnMonitoringPathAnalyzerTest(Constructs.Construct scope, string id, oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VnMonitoringPathAnalyzerTest(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VnMonitoringPathAnalyzerTest(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a VnMonitoringPathAnalyzerTest resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VnMonitoringPathAnalyzerTest to import.</param>
        /// <param name="importFromId">The id of the existing VnMonitoringPathAnalyzerTest that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VnMonitoringPathAnalyzerTest to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VnMonitoringPathAnalyzerTest to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VnMonitoringPathAnalyzerTest that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VnMonitoringPathAnalyzerTest to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.VnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTest), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDestinationEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestDestinationEndpoint\"}}]")]
        public virtual void PutDestinationEndpoint(oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestDestinationEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestDestinationEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProtocolParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestProtocolParameters\"}}]")]
        public virtual void PutProtocolParameters(oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestProtocolParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestProtocolParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestQueryOptions\"}}]")]
        public virtual void PutQueryOptions(oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestQueryOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestQueryOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestSourceEndpoint\"}}]")]
        public virtual void PutSourceEndpoint(oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestSourceEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestSourceEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.VnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTest))!;

        [JsiiProperty(name: "destinationEndpoint", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestDestinationEndpointOutputReference\"}")]
        public virtual oci.VnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestDestinationEndpointOutputReference DestinationEndpoint
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestDestinationEndpointOutputReference>()!;
        }

        [JsiiProperty(name: "protocolParameters", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestProtocolParametersOutputReference\"}")]
        public virtual oci.VnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestProtocolParametersOutputReference ProtocolParameters
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestProtocolParametersOutputReference>()!;
        }

        [JsiiProperty(name: "queryOptions", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestQueryOptionsOutputReference\"}")]
        public virtual oci.VnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestQueryOptionsOutputReference QueryOptions
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestQueryOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "sourceEndpoint", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestSourceEndpointOutputReference\"}")]
        public virtual oci.VnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestSourceEndpointOutputReference SourceEndpoint
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestSourceEndpointOutputReference>()!;
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

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestTimeoutsOutputReference\"}")]
        public virtual oci.VnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationEndpointInput", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestDestinationEndpoint\"}", isOptional: true)]
        public virtual oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestDestinationEndpoint? DestinationEndpointInput
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestDestinationEndpoint?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
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
        [JsiiProperty(name: "protocolParametersInput", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestProtocolParameters\"}", isOptional: true)]
        public virtual oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestProtocolParameters? ProtocolParametersInput
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestProtocolParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryOptionsInput", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestQueryOptions\"}", isOptional: true)]
        public virtual oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestQueryOptions? QueryOptionsInput
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestQueryOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceEndpointInput", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestSourceEndpoint\"}", isOptional: true)]
        public virtual oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestSourceEndpoint? SourceEndpointInput
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestSourceEndpoint?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
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
    }
}
