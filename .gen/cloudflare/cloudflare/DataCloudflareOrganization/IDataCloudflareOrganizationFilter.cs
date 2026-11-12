using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOrganization
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareOrganizationFilter), fullyQualifiedName: "cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilter")]
    public interface IDataCloudflareOrganizationFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#containing DataCloudflareOrganization#containing}.</summary>
        [JsiiProperty(name: "containing", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterContaining\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterContaining? Containing
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sort direction for the `order_by` field. Defaults to `asc` when `order_by` is specified. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#direction DataCloudflareOrganization#direction}
        /// </remarks>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Only return organizations with the specified IDs (ex. id=foo&amp;id=bar). Send multiple elements by repeating the query value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#id DataCloudflareOrganization#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#member DataCloudflareOrganization#member}.</summary>
        [JsiiProperty(name: "member", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterMember\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterMember? Member
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#name DataCloudflareOrganization#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterName\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterName? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Field to order results by. Currently supported values: `name`. When not specified, results are ordered by hierarchy. Available values: "name".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#order_by DataCloudflareOrganization#order_by}
        /// </remarks>
        [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrderBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount of items to return. Defaults to 10.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#page_size DataCloudflareOrganization#page_size}
        /// </remarks>
        [JsiiProperty(name: "pageSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PageSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>An opaque token returned from the last list response that when provided will retrieve the next page.</summary>
        /// <remarks>
        /// Parameters used to filter the retrieved list must remain in subsequent
        /// requests with a page token.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#page_token DataCloudflareOrganization#page_token}
        /// </remarks>
        [JsiiProperty(name: "pageToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PageToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#parent DataCloudflareOrganization#parent}.</summary>
        [JsiiProperty(name: "parent", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterParent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterParent? Parent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareOrganizationFilter), fullyQualifiedName: "cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#containing DataCloudflareOrganization#containing}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containing", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterContaining\"}", isOptional: true)]
            public cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterContaining? Containing
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterContaining?>();
            }

            /// <summary>Sort direction for the `order_by` field. Defaults to `asc` when `order_by` is specified. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#direction DataCloudflareOrganization#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Only return organizations with the specified IDs (ex. id=foo&amp;id=bar). Send multiple elements by repeating the query value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#id DataCloudflareOrganization#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Id
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#member DataCloudflareOrganization#member}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "member", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterMember\"}", isOptional: true)]
            public cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterMember? Member
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterMember?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#name DataCloudflareOrganization#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterName\"}", isOptional: true)]
            public cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterName? Name
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterName?>();
            }

            /// <summary>Field to order results by. Currently supported values: `name`. When not specified, results are ordered by hierarchy. Available values: "name".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#order_by DataCloudflareOrganization#order_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrderBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The amount of items to return. Defaults to 10.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#page_size DataCloudflareOrganization#page_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pageSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PageSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>An opaque token returned from the last list response that when provided will retrieve the next page.</summary>
            /// <remarks>
            /// Parameters used to filter the retrieved list must remain in subsequent
            /// requests with a page token.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#page_token DataCloudflareOrganization#page_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pageToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PageToken
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#parent DataCloudflareOrganization#parent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parent", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterParent\"}", isOptional: true)]
            public cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterParent? Parent
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterParent?>();
            }
        }
    }
}
