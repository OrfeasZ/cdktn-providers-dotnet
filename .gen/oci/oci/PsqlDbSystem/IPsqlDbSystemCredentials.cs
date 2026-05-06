using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IPsqlDbSystemCredentials), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemCredentials")]
    public interface IPsqlDbSystemCredentials
    {
        /// <summary>password_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#password_details PsqlDbSystem#password_details}
        /// </remarks>
        [JsiiProperty(name: "passwordDetails", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemCredentialsPasswordDetails\"}")]
        oci.PsqlDbSystem.IPsqlDbSystemCredentialsPasswordDetails PasswordDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#username PsqlDbSystem#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPsqlDbSystemCredentials), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemCredentials")]
        internal sealed class _Proxy : DeputyBase, oci.PsqlDbSystem.IPsqlDbSystemCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>password_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#password_details PsqlDbSystem#password_details}
            /// </remarks>
            [JsiiProperty(name: "passwordDetails", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemCredentialsPasswordDetails\"}")]
            public oci.PsqlDbSystem.IPsqlDbSystemCredentialsPasswordDetails PasswordDetails
            {
                get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemCredentialsPasswordDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#username PsqlDbSystem#username}.</summary>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
