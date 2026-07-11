using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ServicePrincipalDelegatedPermissionGrant
{
    [JsiiInterface(nativeType: typeof(IServicePrincipalDelegatedPermissionGrantConfig), fullyQualifiedName: "azuread.servicePrincipalDelegatedPermissionGrant.ServicePrincipalDelegatedPermissionGrantConfig")]
    public interface IServicePrincipalDelegatedPermissionGrantConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>A set of claim values for delegated permission scopes which should be included in access tokens for the resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_delegated_permission_grant#claim_values ServicePrincipalDelegatedPermissionGrant#claim_values}
        /// </remarks>
        [JsiiProperty(name: "claimValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ClaimValues
        {
            get;
        }

        /// <summary>The object ID of the service principal representing the resource to be accessed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_delegated_permission_grant#resource_service_principal_object_id ServicePrincipalDelegatedPermissionGrant#resource_service_principal_object_id}
        /// </remarks>
        [JsiiProperty(name: "resourceServicePrincipalObjectId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceServicePrincipalObjectId
        {
            get;
        }

        /// <summary>The object ID of the service principal for which this delegated permission grant should be created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_delegated_permission_grant#service_principal_object_id ServicePrincipalDelegatedPermissionGrant#service_principal_object_id}
        /// </remarks>
        [JsiiProperty(name: "servicePrincipalObjectId", typeJson: "{\"primitive\":\"string\"}")]
        string ServicePrincipalObjectId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_delegated_permission_grant#id ServicePrincipalDelegatedPermissionGrant#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_delegated_permission_grant#timeouts ServicePrincipalDelegatedPermissionGrant#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.servicePrincipalDelegatedPermissionGrant.ServicePrincipalDelegatedPermissionGrantTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.ServicePrincipalDelegatedPermissionGrant.IServicePrincipalDelegatedPermissionGrantTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>The object ID of the user on behalf of whom the service principal is authorized to access the resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_delegated_permission_grant#user_object_id ServicePrincipalDelegatedPermissionGrant#user_object_id}
        /// </remarks>
        [JsiiProperty(name: "userObjectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserObjectId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicePrincipalDelegatedPermissionGrantConfig), fullyQualifiedName: "azuread.servicePrincipalDelegatedPermissionGrant.ServicePrincipalDelegatedPermissionGrantConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.ServicePrincipalDelegatedPermissionGrant.IServicePrincipalDelegatedPermissionGrantConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A set of claim values for delegated permission scopes which should be included in access tokens for the resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_delegated_permission_grant#claim_values ServicePrincipalDelegatedPermissionGrant#claim_values}
            /// </remarks>
            [JsiiProperty(name: "claimValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ClaimValues
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>The object ID of the service principal representing the resource to be accessed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_delegated_permission_grant#resource_service_principal_object_id ServicePrincipalDelegatedPermissionGrant#resource_service_principal_object_id}
            /// </remarks>
            [JsiiProperty(name: "resourceServicePrincipalObjectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceServicePrincipalObjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The object ID of the service principal for which this delegated permission grant should be created.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_delegated_permission_grant#service_principal_object_id ServicePrincipalDelegatedPermissionGrant#service_principal_object_id}
            /// </remarks>
            [JsiiProperty(name: "servicePrincipalObjectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ServicePrincipalObjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_delegated_permission_grant#id ServicePrincipalDelegatedPermissionGrant#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_delegated_permission_grant#timeouts ServicePrincipalDelegatedPermissionGrant#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.servicePrincipalDelegatedPermissionGrant.ServicePrincipalDelegatedPermissionGrantTimeouts\"}", isOptional: true)]
            public azuread.ServicePrincipalDelegatedPermissionGrant.IServicePrincipalDelegatedPermissionGrantTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.ServicePrincipalDelegatedPermissionGrant.IServicePrincipalDelegatedPermissionGrantTimeouts?>();
            }

            /// <summary>The object ID of the user on behalf of whom the service principal is authorized to access the resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_delegated_permission_grant#user_object_id ServicePrincipalDelegatedPermissionGrant#user_object_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userObjectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserObjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
