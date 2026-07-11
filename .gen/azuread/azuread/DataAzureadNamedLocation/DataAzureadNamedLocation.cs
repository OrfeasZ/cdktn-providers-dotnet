using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadNamedLocation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/named_location azuread_named_location}.</summary>
    [JsiiClass(nativeType: typeof(azuread.DataAzureadNamedLocation.DataAzureadNamedLocation), fullyQualifiedName: "azuread.dataAzureadNamedLocation.DataAzureadNamedLocation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuread.dataAzureadNamedLocation.DataAzureadNamedLocationConfig\"}}]")]
    public class DataAzureadNamedLocation : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/named_location azuread_named_location} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzureadNamedLocation(Constructs.Construct scope, string id, azuread.DataAzureadNamedLocation.IDataAzureadNamedLocationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuread.DataAzureadNamedLocation.IDataAzureadNamedLocationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzureadNamedLocation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzureadNamedLocation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzureadNamedLocation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzureadNamedLocation to import.</param>
        /// <param name="importFromId">The id of the existing DataAzureadNamedLocation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzureadNamedLocation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzureadNamedLocation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/named_location#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzureadNamedLocation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzureadNamedLocation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuread.DataAzureadNamedLocation.DataAzureadNamedLocation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.dataAzureadNamedLocation.DataAzureadNamedLocationTimeouts\"}}]")]
        public virtual void PutTimeouts(azuread.DataAzureadNamedLocation.IDataAzureadNamedLocationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.DataAzureadNamedLocation.IDataAzureadNamedLocationTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azuread.DataAzureadNamedLocation.DataAzureadNamedLocation))!;

        [JsiiProperty(name: "country", typeJson: "{\"fqn\":\"azuread.dataAzureadNamedLocation.DataAzureadNamedLocationCountryList\"}")]
        public virtual azuread.DataAzureadNamedLocation.DataAzureadNamedLocationCountryList Country
        {
            get => GetInstanceProperty<azuread.DataAzureadNamedLocation.DataAzureadNamedLocationCountryList>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"azuread.dataAzureadNamedLocation.DataAzureadNamedLocationIpList\"}")]
        public virtual azuread.DataAzureadNamedLocation.DataAzureadNamedLocationIpList Ip
        {
            get => GetInstanceProperty<azuread.DataAzureadNamedLocation.DataAzureadNamedLocationIpList>()!;
        }

        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.dataAzureadNamedLocation.DataAzureadNamedLocationTimeoutsOutputReference\"}")]
        public virtual azuread.DataAzureadNamedLocation.DataAzureadNamedLocationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuread.DataAzureadNamedLocation.DataAzureadNamedLocationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuread.DataAzureadNamedLocation.IDataAzureadNamedLocationTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuread.dataAzureadNamedLocation.DataAzureadNamedLocationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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
