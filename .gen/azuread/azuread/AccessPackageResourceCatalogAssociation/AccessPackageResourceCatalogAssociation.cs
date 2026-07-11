using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageResourceCatalogAssociation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_resource_catalog_association azuread_access_package_resource_catalog_association}.</summary>
    [JsiiClass(nativeType: typeof(azuread.AccessPackageResourceCatalogAssociation.AccessPackageResourceCatalogAssociation), fullyQualifiedName: "azuread.accessPackageResourceCatalogAssociation.AccessPackageResourceCatalogAssociation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuread.accessPackageResourceCatalogAssociation.AccessPackageResourceCatalogAssociationConfig\"}}]")]
    public class AccessPackageResourceCatalogAssociation : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_resource_catalog_association azuread_access_package_resource_catalog_association} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AccessPackageResourceCatalogAssociation(Constructs.Construct scope, string id, azuread.AccessPackageResourceCatalogAssociation.IAccessPackageResourceCatalogAssociationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuread.AccessPackageResourceCatalogAssociation.IAccessPackageResourceCatalogAssociationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AccessPackageResourceCatalogAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AccessPackageResourceCatalogAssociation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a AccessPackageResourceCatalogAssociation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AccessPackageResourceCatalogAssociation to import.</param>
        /// <param name="importFromId">The id of the existing AccessPackageResourceCatalogAssociation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AccessPackageResourceCatalogAssociation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AccessPackageResourceCatalogAssociation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_resource_catalog_association#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AccessPackageResourceCatalogAssociation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AccessPackageResourceCatalogAssociation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuread.AccessPackageResourceCatalogAssociation.AccessPackageResourceCatalogAssociation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.accessPackageResourceCatalogAssociation.AccessPackageResourceCatalogAssociationTimeouts\"}}]")]
        public virtual void PutTimeouts(azuread.AccessPackageResourceCatalogAssociation.IAccessPackageResourceCatalogAssociationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.AccessPackageResourceCatalogAssociation.IAccessPackageResourceCatalogAssociationTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azuread.AccessPackageResourceCatalogAssociation.AccessPackageResourceCatalogAssociation))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.accessPackageResourceCatalogAssociation.AccessPackageResourceCatalogAssociationTimeoutsOutputReference\"}")]
        public virtual azuread.AccessPackageResourceCatalogAssociation.AccessPackageResourceCatalogAssociationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuread.AccessPackageResourceCatalogAssociation.AccessPackageResourceCatalogAssociationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CatalogIdInput
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
        [JsiiProperty(name: "resourceOriginIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceOriginIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceOriginSystemInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceOriginSystemInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuread.AccessPackageResourceCatalogAssociation.IAccessPackageResourceCatalogAssociationTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuread.accessPackageResourceCatalogAssociation.AccessPackageResourceCatalogAssociationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CatalogId
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

        [JsiiProperty(name: "resourceOriginId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceOriginId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceOriginSystem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceOriginSystem
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
