using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageCatalogRoleAssignment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_catalog_role_assignment azuread_access_package_catalog_role_assignment}.</summary>
    [JsiiClass(nativeType: typeof(azuread.AccessPackageCatalogRoleAssignment.AccessPackageCatalogRoleAssignment), fullyQualifiedName: "azuread.accessPackageCatalogRoleAssignment.AccessPackageCatalogRoleAssignment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuread.accessPackageCatalogRoleAssignment.AccessPackageCatalogRoleAssignmentConfig\"}}]")]
    public class AccessPackageCatalogRoleAssignment : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_catalog_role_assignment azuread_access_package_catalog_role_assignment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AccessPackageCatalogRoleAssignment(Constructs.Construct scope, string id, azuread.AccessPackageCatalogRoleAssignment.IAccessPackageCatalogRoleAssignmentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuread.AccessPackageCatalogRoleAssignment.IAccessPackageCatalogRoleAssignmentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AccessPackageCatalogRoleAssignment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AccessPackageCatalogRoleAssignment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a AccessPackageCatalogRoleAssignment resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AccessPackageCatalogRoleAssignment to import.</param>
        /// <param name="importFromId">The id of the existing AccessPackageCatalogRoleAssignment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AccessPackageCatalogRoleAssignment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AccessPackageCatalogRoleAssignment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_catalog_role_assignment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AccessPackageCatalogRoleAssignment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AccessPackageCatalogRoleAssignment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuread.AccessPackageCatalogRoleAssignment.AccessPackageCatalogRoleAssignment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.accessPackageCatalogRoleAssignment.AccessPackageCatalogRoleAssignmentTimeouts\"}}]")]
        public virtual void PutTimeouts(azuread.AccessPackageCatalogRoleAssignment.IAccessPackageCatalogRoleAssignmentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.AccessPackageCatalogRoleAssignment.IAccessPackageCatalogRoleAssignmentTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azuread.AccessPackageCatalogRoleAssignment.AccessPackageCatalogRoleAssignment))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.accessPackageCatalogRoleAssignment.AccessPackageCatalogRoleAssignmentTimeoutsOutputReference\"}")]
        public virtual azuread.AccessPackageCatalogRoleAssignment.AccessPackageCatalogRoleAssignmentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuread.AccessPackageCatalogRoleAssignment.AccessPackageCatalogRoleAssignmentTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "principalObjectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrincipalObjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuread.AccessPackageCatalogRoleAssignment.IAccessPackageCatalogRoleAssignmentTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuread.accessPackageCatalogRoleAssignment.AccessPackageCatalogRoleAssignmentTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "principalObjectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrincipalObjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
