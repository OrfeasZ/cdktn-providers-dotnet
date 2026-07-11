using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadDirectoryRoleTemplates
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/directory_role_templates azuread_directory_role_templates}.</summary>
    [JsiiClass(nativeType: typeof(azuread.DataAzureadDirectoryRoleTemplates.DataAzureadDirectoryRoleTemplates), fullyQualifiedName: "azuread.dataAzureadDirectoryRoleTemplates.DataAzureadDirectoryRoleTemplates", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"azuread.dataAzureadDirectoryRoleTemplates.DataAzureadDirectoryRoleTemplatesConfig\"}}]")]
    public class DataAzureadDirectoryRoleTemplates : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/directory_role_templates azuread_directory_role_templates} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzureadDirectoryRoleTemplates(Constructs.Construct scope, string id, azuread.DataAzureadDirectoryRoleTemplates.IDataAzureadDirectoryRoleTemplatesConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuread.DataAzureadDirectoryRoleTemplates.IDataAzureadDirectoryRoleTemplatesConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzureadDirectoryRoleTemplates(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzureadDirectoryRoleTemplates(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzureadDirectoryRoleTemplates resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzureadDirectoryRoleTemplates to import.</param>
        /// <param name="importFromId">The id of the existing DataAzureadDirectoryRoleTemplates that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzureadDirectoryRoleTemplates to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzureadDirectoryRoleTemplates to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/directory_role_templates#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzureadDirectoryRoleTemplates that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzureadDirectoryRoleTemplates to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuread.DataAzureadDirectoryRoleTemplates.DataAzureadDirectoryRoleTemplates), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.dataAzureadDirectoryRoleTemplates.DataAzureadDirectoryRoleTemplatesTimeouts\"}}]")]
        public virtual void PutTimeouts(azuread.DataAzureadDirectoryRoleTemplates.IDataAzureadDirectoryRoleTemplatesTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.DataAzureadDirectoryRoleTemplates.IDataAzureadDirectoryRoleTemplatesTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azuread.DataAzureadDirectoryRoleTemplates.DataAzureadDirectoryRoleTemplates))!;

        [JsiiProperty(name: "objectIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ObjectIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "roleTemplates", typeJson: "{\"fqn\":\"azuread.dataAzureadDirectoryRoleTemplates.DataAzureadDirectoryRoleTemplatesRoleTemplatesList\"}")]
        public virtual azuread.DataAzureadDirectoryRoleTemplates.DataAzureadDirectoryRoleTemplatesRoleTemplatesList RoleTemplates
        {
            get => GetInstanceProperty<azuread.DataAzureadDirectoryRoleTemplates.DataAzureadDirectoryRoleTemplatesRoleTemplatesList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.dataAzureadDirectoryRoleTemplates.DataAzureadDirectoryRoleTemplatesTimeoutsOutputReference\"}")]
        public virtual azuread.DataAzureadDirectoryRoleTemplates.DataAzureadDirectoryRoleTemplatesTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuread.DataAzureadDirectoryRoleTemplates.DataAzureadDirectoryRoleTemplatesTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuread.DataAzureadDirectoryRoleTemplates.IDataAzureadDirectoryRoleTemplatesTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuread.dataAzureadDirectoryRoleTemplates.DataAzureadDirectoryRoleTemplatesTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
