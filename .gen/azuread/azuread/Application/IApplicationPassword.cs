using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    [JsiiInterface(nativeType: typeof(IApplicationPassword), fullyQualifiedName: "azuread.application.ApplicationPassword")]
    public interface IApplicationPassword
    {
        /// <summary>A display name for the password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#display_name Application#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>The end date until which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#end_date Application#end_date}
        /// </remarks>
        [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>The start date from which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn't specified, the current date is used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#start_date Application#start_date}
        /// </remarks>
        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartDate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationPassword), fullyQualifiedName: "azuread.application.ApplicationPassword")]
        internal sealed class _Proxy : DeputyBase, azuread.Application.IApplicationPassword
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A display name for the password.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#display_name Application#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The end date until which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#end_date Application#end_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The start date from which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn't specified, the current date is used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#start_date Application#start_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartDate
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
