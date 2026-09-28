using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azapi.DataAzapiDataPlaneResource
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource azapi_data_plane_resource}.</summary>
    [JsiiClass(nativeType: typeof(azapi.DataAzapiDataPlaneResource.DataAzapiDataPlaneResource), fullyQualifiedName: "azapi.dataAzapiDataPlaneResource.DataAzapiDataPlaneResource", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azapi.dataAzapiDataPlaneResource.DataAzapiDataPlaneResourceConfig\"}}]")]
    public class DataAzapiDataPlaneResource : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource azapi_data_plane_resource} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzapiDataPlaneResource(Constructs.Construct scope, string id, azapi.DataAzapiDataPlaneResource.IDataAzapiDataPlaneResourceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azapi.DataAzapiDataPlaneResource.IDataAzapiDataPlaneResourceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzapiDataPlaneResource(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzapiDataPlaneResource(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzapiDataPlaneResource resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzapiDataPlaneResource to import.</param>
        /// <param name="importFromId">The id of the existing DataAzapiDataPlaneResource that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzapiDataPlaneResource to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzapiDataPlaneResource to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/data-sources/data_plane_resource#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzapiDataPlaneResource that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzapiDataPlaneResource to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azapi.DataAzapiDataPlaneResource.DataAzapiDataPlaneResource), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putRetry", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azapi.dataAzapiDataPlaneResource.DataAzapiDataPlaneResourceRetry\"}}]")]
        public virtual void PutRetry(azapi.DataAzapiDataPlaneResource.IDataAzapiDataPlaneResourceRetry @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azapi.DataAzapiDataPlaneResource.IDataAzapiDataPlaneResourceRetry)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azapi.dataAzapiDataPlaneResource.DataAzapiDataPlaneResourceTimeouts\"}}]")]
        public virtual void PutTimeouts(azapi.DataAzapiDataPlaneResource.IDataAzapiDataPlaneResourceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azapi.DataAzapiDataPlaneResource.IDataAzapiDataPlaneResourceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponseExportValues")]
        public virtual void ResetResponseExportValues()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetry")]
        public virtual void ResetRetry()
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
        = GetStaticProperty<string>(typeof(azapi.DataAzapiDataPlaneResource.DataAzapiDataPlaneResource))!;

        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"cdktn.AnyMap\"}")]
        public virtual Io.Cdktn.AnyMap Body
        {
            get => GetInstanceProperty<Io.Cdktn.AnyMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"cdktn.AnyMap\"}")]
        public virtual Io.Cdktn.AnyMap Output
        {
            get => GetInstanceProperty<Io.Cdktn.AnyMap>()!;
        }

        [JsiiProperty(name: "retry", typeJson: "{\"fqn\":\"azapi.dataAzapiDataPlaneResource.DataAzapiDataPlaneResourceRetryOutputReference\"}")]
        public virtual azapi.DataAzapiDataPlaneResource.DataAzapiDataPlaneResourceRetryOutputReference Retry
        {
            get => GetInstanceProperty<azapi.DataAzapiDataPlaneResource.DataAzapiDataPlaneResourceRetryOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azapi.dataAzapiDataPlaneResource.DataAzapiDataPlaneResourceTimeoutsOutputReference\"}")]
        public virtual azapi.DataAzapiDataPlaneResource.DataAzapiDataPlaneResourceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azapi.DataAzapiDataPlaneResource.DataAzapiDataPlaneResourceTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseExportValuesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, object>? ResponseExportValuesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azapi.DataAzapiDataPlaneResource.IDataAzapiDataPlaneResourceRetry" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azapi.dataAzapiDataPlaneResource.DataAzapiDataPlaneResourceRetry\"}]}}", isOptional: true)]
        public virtual object? RetryInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azapi.DataAzapiDataPlaneResource.IDataAzapiDataPlaneResourceTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azapi.dataAzapiDataPlaneResource.DataAzapiDataPlaneResourceTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseExportValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, object> ResponseExportValues
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>>()!;
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
