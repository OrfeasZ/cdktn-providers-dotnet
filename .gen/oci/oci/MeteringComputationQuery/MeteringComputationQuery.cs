using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationQuery
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query oci_metering_computation_query}.</summary>
    [JsiiClass(nativeType: typeof(oci.MeteringComputationQuery.MeteringComputationQuery), fullyQualifiedName: "oci.meteringComputationQuery.MeteringComputationQuery", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryConfig\"}}]")]
    public class MeteringComputationQuery : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query oci_metering_computation_query} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MeteringComputationQuery(Constructs.Construct scope, string id, oci.MeteringComputationQuery.IMeteringComputationQueryConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.MeteringComputationQuery.IMeteringComputationQueryConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MeteringComputationQuery(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MeteringComputationQuery(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a MeteringComputationQuery resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MeteringComputationQuery to import.</param>
        /// <param name="importFromId">The id of the existing MeteringComputationQuery that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MeteringComputationQuery to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MeteringComputationQuery to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MeteringComputationQuery that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MeteringComputationQuery to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.MeteringComputationQuery.MeteringComputationQuery), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putQueryDefinition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinition\"}}]")]
        public virtual void PutQueryDefinition(oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.MeteringComputationQuery.IMeteringComputationQueryTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MeteringComputationQuery.IMeteringComputationQueryTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.MeteringComputationQuery.MeteringComputationQuery))!;

        [JsiiProperty(name: "queryDefinition", typeJson: "{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionOutputReference\"}")]
        public virtual oci.MeteringComputationQuery.MeteringComputationQueryQueryDefinitionOutputReference QueryDefinition
        {
            get => GetInstanceProperty<oci.MeteringComputationQuery.MeteringComputationQueryQueryDefinitionOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryTimeoutsOutputReference\"}")]
        public virtual oci.MeteringComputationQuery.MeteringComputationQueryTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.MeteringComputationQuery.MeteringComputationQueryTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
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
        [JsiiProperty(name: "queryDefinitionInput", typeJson: "{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinition\"}", isOptional: true)]
        public virtual oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinition? QueryDefinitionInput
        {
            get => GetInstanceProperty<oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
