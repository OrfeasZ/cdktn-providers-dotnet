using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDataPlaneGenerateScopedAccessToken
{
    [JsiiByValue(fqn: "oci.identityDataPlaneGenerateScopedAccessToken.IdentityDataPlaneGenerateScopedAccessTokenTimeouts")]
    public class IdentityDataPlaneGenerateScopedAccessTokenTimeouts : oci.IdentityDataPlaneGenerateScopedAccessToken.IIdentityDataPlaneGenerateScopedAccessTokenTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_data_plane_generate_scoped_access_token#create IdentityDataPlaneGenerateScopedAccessToken#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_data_plane_generate_scoped_access_token#delete IdentityDataPlaneGenerateScopedAccessToken#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_data_plane_generate_scoped_access_token#update IdentityDataPlaneGenerateScopedAccessToken#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
