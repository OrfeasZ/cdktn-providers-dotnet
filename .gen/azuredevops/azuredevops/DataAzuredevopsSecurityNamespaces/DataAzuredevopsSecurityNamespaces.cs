using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsSecurityNamespaces
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/security_namespaces azuredevops_security_namespaces}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.DataAzuredevopsSecurityNamespaces.DataAzuredevopsSecurityNamespaces), fullyQualifiedName: "azuredevops.dataAzuredevopsSecurityNamespaces.DataAzuredevopsSecurityNamespaces", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"azuredevops.dataAzuredevopsSecurityNamespaces.DataAzuredevopsSecurityNamespacesConfig\"}}]")]
    public class DataAzuredevopsSecurityNamespaces : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/security_namespaces azuredevops_security_namespaces} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzuredevopsSecurityNamespaces(Constructs.Construct scope, string id, azuredevops.DataAzuredevopsSecurityNamespaces.IDataAzuredevopsSecurityNamespacesConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.DataAzuredevopsSecurityNamespaces.IDataAzuredevopsSecurityNamespacesConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzuredevopsSecurityNamespaces(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzuredevopsSecurityNamespaces(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzuredevopsSecurityNamespaces resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzuredevopsSecurityNamespaces to import.</param>
        /// <param name="importFromId">The id of the existing DataAzuredevopsSecurityNamespaces that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzuredevopsSecurityNamespaces to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzuredevopsSecurityNamespaces to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/security_namespaces#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzuredevopsSecurityNamespaces that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzuredevopsSecurityNamespaces to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuredevops.DataAzuredevopsSecurityNamespaces.DataAzuredevopsSecurityNamespaces), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.dataAzuredevopsSecurityNamespaces.DataAzuredevopsSecurityNamespacesTimeouts\"}}]")]
        public virtual void PutTimeouts(azuredevops.DataAzuredevopsSecurityNamespaces.IDataAzuredevopsSecurityNamespacesTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.DataAzuredevopsSecurityNamespaces.IDataAzuredevopsSecurityNamespacesTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azuredevops.DataAzuredevopsSecurityNamespaces.DataAzuredevopsSecurityNamespaces))!;

        [JsiiProperty(name: "namespaces", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsSecurityNamespaces.DataAzuredevopsSecurityNamespacesNamespacesList\"}")]
        public virtual azuredevops.DataAzuredevopsSecurityNamespaces.DataAzuredevopsSecurityNamespacesNamespacesList Namespaces
        {
            get => GetInstanceProperty<azuredevops.DataAzuredevopsSecurityNamespaces.DataAzuredevopsSecurityNamespacesNamespacesList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsSecurityNamespaces.DataAzuredevopsSecurityNamespacesTimeoutsOutputReference\"}")]
        public virtual azuredevops.DataAzuredevopsSecurityNamespaces.DataAzuredevopsSecurityNamespacesTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuredevops.DataAzuredevopsSecurityNamespaces.DataAzuredevopsSecurityNamespacesTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuredevops.DataAzuredevopsSecurityNamespaces.IDataAzuredevopsSecurityNamespacesTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuredevops.dataAzuredevopsSecurityNamespaces.DataAzuredevopsSecurityNamespacesTimeouts\"}]}}", isOptional: true)]
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
