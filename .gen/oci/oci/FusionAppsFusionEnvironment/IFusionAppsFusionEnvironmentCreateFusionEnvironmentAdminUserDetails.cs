using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironment
{
    [JsiiInterface(nativeType: typeof(IFusionAppsFusionEnvironmentCreateFusionEnvironmentAdminUserDetails), fullyQualifiedName: "oci.fusionAppsFusionEnvironment.FusionAppsFusionEnvironmentCreateFusionEnvironmentAdminUserDetails")]
    public interface IFusionAppsFusionEnvironmentCreateFusionEnvironmentAdminUserDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#email_address FusionAppsFusionEnvironment#email_address}.</summary>
        [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}")]
        string EmailAddress
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#first_name FusionAppsFusionEnvironment#first_name}.</summary>
        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
        string FirstName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#last_name FusionAppsFusionEnvironment#last_name}.</summary>
        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
        string LastName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#username FusionAppsFusionEnvironment#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#password FusionAppsFusionEnvironment#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFusionAppsFusionEnvironmentCreateFusionEnvironmentAdminUserDetails), fullyQualifiedName: "oci.fusionAppsFusionEnvironment.FusionAppsFusionEnvironmentCreateFusionEnvironmentAdminUserDetails")]
        internal sealed class _Proxy : DeputyBase, oci.FusionAppsFusionEnvironment.IFusionAppsFusionEnvironmentCreateFusionEnvironmentAdminUserDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#email_address FusionAppsFusionEnvironment#email_address}.</summary>
            [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string EmailAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#first_name FusionAppsFusionEnvironment#first_name}.</summary>
            [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
            public string FirstName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#last_name FusionAppsFusionEnvironment#last_name}.</summary>
            [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
            public string LastName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#username FusionAppsFusionEnvironment#username}.</summary>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#password FusionAppsFusionEnvironment#password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
