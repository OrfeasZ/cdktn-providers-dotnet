using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDataPlaneGenerateScopedAccessToken
{
    [JsiiInterface(nativeType: typeof(IIdentityDataPlaneGenerateScopedAccessTokenTimeouts), fullyQualifiedName: "oci.identityDataPlaneGenerateScopedAccessToken.IdentityDataPlaneGenerateScopedAccessTokenTimeouts")]
    public interface IIdentityDataPlaneGenerateScopedAccessTokenTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_data_plane_generate_scoped_access_token#create IdentityDataPlaneGenerateScopedAccessToken#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_data_plane_generate_scoped_access_token#delete IdentityDataPlaneGenerateScopedAccessToken#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_data_plane_generate_scoped_access_token#update IdentityDataPlaneGenerateScopedAccessToken#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDataPlaneGenerateScopedAccessTokenTimeouts), fullyQualifiedName: "oci.identityDataPlaneGenerateScopedAccessToken.IdentityDataPlaneGenerateScopedAccessTokenTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDataPlaneGenerateScopedAccessToken.IIdentityDataPlaneGenerateScopedAccessTokenTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_data_plane_generate_scoped_access_token#create IdentityDataPlaneGenerateScopedAccessToken#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_data_plane_generate_scoped_access_token#delete IdentityDataPlaneGenerateScopedAccessToken#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_data_plane_generate_scoped_access_token#update IdentityDataPlaneGenerateScopedAccessToken#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
