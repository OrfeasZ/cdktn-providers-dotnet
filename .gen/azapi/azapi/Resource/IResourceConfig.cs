using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azapi.Resource
{
    [JsiiInterface(nativeType: typeof(IResourceConfig), fullyQualifiedName: "azapi.resource.ResourceConfig")]
    public interface IResourceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>In a format like `&lt;resource-type&gt;@&lt;api-version&gt;`.</summary>
        /// <remarks>
        /// <c>&lt;resource-type&gt;</c> is the Azure resource type, for example, <c>Microsoft.Storage/storageAccounts</c>. <c>&lt;api-version&gt;</c> is version of the API used to manage this azure resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#type Resource#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>A dynamic attribute that contains the request body.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#body Resource#body}
        /// </remarks>
        [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, object>? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>A mapping of headers to be sent with the create request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#create_headers Resource#create_headers}
        /// </remarks>
        [JsiiProperty(name: "createHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? CreateHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>A mapping of query parameters to be sent with the create request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#create_query_parameters Resource#create_query_parameters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "createQueryParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CreateQueryParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>A mapping of headers to be sent with the delete request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#delete_headers Resource#delete_headers}
        /// </remarks>
        [JsiiProperty(name: "deleteHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DeleteHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>A mapping of query parameters to be sent with the delete request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#delete_query_parameters Resource#delete_query_parameters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "deleteQueryParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeleteQueryParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#identity Resource#identity}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azapi.Resource.IResourceIdentity" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azapi.resource.ResourceIdentity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of paths in the resource body whose changes should be ignored.</summary>
        /// <remarks>
        /// Prefer Terraform's <c>lifecycle.ignore_changes</c> when possible. Use this argument only when the paths must be derived from variables or other non-static values. Changes to this argument take effect only after an apply because its value is stored in provider-private state. Paths use dot notation, for example <c>properties.sku.name</c>. Individual list items cannot be targeted, ignore the entire list property instead. Configuration changes at an ignored path will not be sent to Azure until that path is removed from this list. This write-only argument requires Terraform 1.11 or later.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#ignore_body_changes Resource#ignore_body_changes}
        /// </remarks>
        [JsiiProperty(name: "ignoreBodyChanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IgnoreBodyChanges
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether ignore the casing of the property names in the response body.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#ignore_casing Resource#ignore_casing}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "ignoreCasing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IgnoreCasing
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether ignore not returned properties like credentials in `body` to suppress plan-diff.</summary>
        /// <remarks>
        /// It's recommend to enable this option when some sensitive properties are not returned in response body, instead of setting them in <c>lifecycle.ignore_changes</c> because it will make the sensitive fields unable to update.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#ignore_missing_property Resource#ignore_missing_property}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "ignoreMissingProperty", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IgnoreMissingProperty
        {
            get
            {
                return null;
            }
        }

        /// <summary>When set to `true`, the provider will ignore properties whose values are `null` in the `body`.</summary>
        /// <remarks>
        /// These properties will not be included in the request body sent to the API, and the difference will not be shown in the plan output.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#ignore_null_property Resource#ignore_null_property}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "ignoreNullProperty", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IgnoreNullProperty
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of list property paths where items not specified in configuration should be ignored.</summary>
        /// <remarks>
        /// This is intended for partial list management when combined with <c>list_unique_id_property</c> (for example, to avoid perpetual drift from server-side ordering).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#ignore_other_items_in_list Resource#ignore_other_items_in_list}
        /// </remarks>
        [JsiiProperty(name: "ignoreOtherItemsInList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IgnoreOtherItemsInList
        {
            get
            {
                return null;
            }
        }

        /// <summary>A mapping of list property paths to the field name used as a unique identifier when comparing and merging list items.</summary>
        /// <remarks>
        /// When not set, list items are matched by a <c>name</c> property (if present) or by list ordering. To match using multiple fields, specify a comma-separated list of field names (e.g., <c>"category, categoryGroup"</c>).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#list_unique_id_property Resource#list_unique_id_property}
        /// </remarks>
        [JsiiProperty(name: "listUniqueIdProperty", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? ListUniqueIdProperty
        {
            get
            {
                return null;
            }
        }

        /// <summary>The location of the Azure resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#location Resource#location}
        /// </remarks>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Location
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of ARM resource IDs which are used to avoid create/modify/delete azapi resources at the same time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#locks Resource#locks}
        /// </remarks>
        [JsiiProperty(name: "locks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Locks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the name of the azure resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#name Resource#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the azure resource in which this resource is created.</summary>
        /// <remarks>
        /// It supports different kinds of deployment scope for <strong>top level</strong> resources:
        ///
        /// <list type="bullet">
        /// <description>resource group scope: <c>parent_id</c> should be the ID of a resource group, it's recommended to manage a resource group by azurerm_resource_group.</description>
        /// <description>management group scope: <c>parent_id</c> should be the ID of a management group, it's recommended to manage a management group by azurerm_management_group.</description>
        /// <description>extension scope: <c>parent_id</c> should be the ID of the resource you're adding the extension to.</description>
        /// <description>subscription scope: <c>parent_id</c> should be like \x60/subscriptions/00000000-0000-0000-0000-000000000000\x60</description>
        /// <description>tenant scope: <c>parent_id</c> should be /</description>
        /// </list>
        ///
        /// For child level resources, the <c>parent_id</c> should be the ID of its parent resource, for example, subnet resource's <c>parent_id</c> is the ID of the vnet.
        ///
        /// For type <c>Microsoft.Resources/resourceGroups</c>, the <c>parent_id</c> could be omitted, it defaults to subscription ID specified in provider or the default subscription (You could check the default subscription by azure cli command: <c>az account show</c>).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#parent_id Resource#parent_id}
        /// </remarks>
        [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>A mapping of headers to be sent with the read request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#read_headers Resource#read_headers}
        /// </remarks>
        [JsiiProperty(name: "readHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? ReadHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>A mapping of query parameters to be sent with the read request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#read_query_parameters Resource#read_query_parameters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "readQueryParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReadQueryParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Will trigger a replace of the resource when the value changes and is not `null`.</summary>
        /// <remarks>
        /// This can be used by practitioners to force a replace of the resource when certain values change, e.g. changing the SKU of a virtual machine based on the value of variables or locals. The value is a <c>dynamic</c>, so practitioners can compose the input however they wish. For a "break glass" set the value to <c>null</c> to prevent the plan modifier taking effect.
        /// If you have <c>null</c> values that you do want to be tracked as affecting the resource replacement, include these inside an object.
        /// Advanced use cases are possible and resource replacement can be triggered by values external to the resource, for example when a dependent resource changes.
        ///
        /// e.g. to replace a resource when either the SKU or os_type attributes change:
        ///
        /// <code><![CDATA[
        /// resource "azapi_resource" "example" {
        ///   name      = var.name
        ///   type      = "Microsoft.Network/publicIPAddresses@2023-11-01"
        ///   parent_id = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/example"
        ///   body = {
        ///     properties = {
        ///       sku   = var.sku
        ///       zones = var.zones
        ///     }
        ///   }
        ///
        ///   replace_triggers_external_values = [
        ///     var.sku,
        ///     var.zones,
        ///   ]
        /// }
        /// ]]></code>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#replace_triggers_external_values Resource#replace_triggers_external_values}
        /// </remarks>
        [JsiiProperty(name: "replaceTriggersExternalValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, object>? ReplaceTriggersExternalValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of paths in the current Terraform configuration.</summary>
        /// <remarks>
        /// When the values at these paths change, the resource will be replaced.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#replace_triggers_refs Resource#replace_triggers_refs}
        /// </remarks>
        [JsiiProperty(name: "replaceTriggersRefs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ReplaceTriggersRefs
        {
            get
            {
                return null;
            }
        }

        /// <summary>The attribute can accept either a list or a map.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description><strong>List</strong>: A list of paths that need to be exported from the response body. Setting it to <c>["*"]</c> will export the full response body. Here's an example. If it sets to <c>["properties.loginServer", "properties.policies.quarantinePolicy.status"]</c>, it will set the following HCL object to the computed property output.
        ///
        /// <code><![CDATA[
        /// {
        /// 	properties = {
        /// 		loginServer = "registry1.azurecr.io"
        /// 		policies = {
        /// 			quarantinePolicy = {
        /// 				status = "disabled"
        /// 			}
        /// 		}
        /// 	}
        /// }
        /// ]]></code></description>
        /// <description><strong>Map</strong>: A map where the key is the name for the result and the value is a JMESPath query string to filter the response. Here's an example. If it sets to <c>{"login_server": "properties.loginServer", "quarantine_status": "properties.policies.quarantinePolicy.status"}</c>, it will set the following HCL object to the computed property output.
        ///
        /// <code><![CDATA[
        /// {
        /// 	"login_server" = "registry1.azurecr.io"
        /// 	"quarantine_status" = "disabled"
        /// }
        /// ]]></code></description>
        /// </list>
        ///
        /// To learn more about JMESPath, visit <a href="https://jmespath.org/">JMESPath</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#response_export_values Resource#response_export_values}
        /// </remarks>
        [JsiiProperty(name: "responseExportValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, object>? ResponseExportValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>The retry object supports the following attributes:.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#retry Resource#retry}
        /// </remarks>
        [JsiiProperty(name: "retry", typeJson: "{\"fqn\":\"azapi.resource.ResourceRetry\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azapi.Resource.IResourceRetry? Retry
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether enabled the validation on `type` and `body` with embedded schema.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#schema_validation_enabled Resource#schema_validation_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "schemaValidationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SchemaValidationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>A dynamic attribute that contains the write-only properties of the request body.</summary>
        /// <remarks>
        /// This will be merge-patched to the body to construct the actual request body. If a property is defined in both <c>body</c> and <c>sensitive_body</c>, the <c>sensitive_body</c> value takes precedence.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#sensitive_body Resource#sensitive_body}
        /// </remarks>
        [JsiiProperty(name: "sensitiveBody", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, object>? SensitiveBody
        {
            get
            {
                return null;
            }
        }

        /// <summary>A map where the key is the path to the property in `sensitive_body` and the value is the version of the property.</summary>
        /// <remarks>
        /// The key is a string in the format of <c>path.to.property[index].subproperty</c>, where <c>index</c> is the index of the item in an array. When the version is changed, the property will be included in the request body, otherwise it will be omitted from the request body.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#sensitive_body_version Resource#sensitive_body_version}
        /// </remarks>
        [JsiiProperty(name: "sensitiveBodyVersion", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? SensitiveBodyVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>A mapping of tags which should be assigned to the Azure resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#tags Resource#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#timeouts Resource#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azapi.resource.ResourceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azapi.Resource.IResourceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>A mapping of headers to be sent with the update request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#update_headers Resource#update_headers}
        /// </remarks>
        [JsiiProperty(name: "updateHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? UpdateHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>A mapping of query parameters to be sent with the update request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#update_query_parameters Resource#update_query_parameters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "updateQueryParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UpdateQueryParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResourceConfig), fullyQualifiedName: "azapi.resource.ResourceConfig")]
        internal sealed class _Proxy : DeputyBase, azapi.Resource.IResourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>In a format like `&lt;resource-type&gt;@&lt;api-version&gt;`.</summary>
            /// <remarks>
            /// <c>&lt;resource-type&gt;</c> is the Azure resource type, for example, <c>Microsoft.Storage/storageAccounts</c>. <c>&lt;api-version&gt;</c> is version of the API used to manage this azure resource.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#type Resource#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A dynamic attribute that contains the request body.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#body Resource#body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, object>? Body
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>?>();
            }

            /// <summary>A mapping of headers to be sent with the create request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#create_headers Resource#create_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? CreateHeaders
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>A mapping of query parameters to be sent with the create request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#create_query_parameters Resource#create_query_parameters}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createQueryParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? CreateQueryParameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A mapping of headers to be sent with the delete request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#delete_headers Resource#delete_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DeleteHeaders
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>A mapping of query parameters to be sent with the delete request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#delete_query_parameters Resource#delete_query_parameters}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteQueryParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? DeleteQueryParameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#identity Resource#identity}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azapi.Resource.IResourceIdentity" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azapi.resource.ResourceIdentity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Identity
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A list of paths in the resource body whose changes should be ignored.</summary>
            /// <remarks>
            /// Prefer Terraform's <c>lifecycle.ignore_changes</c> when possible. Use this argument only when the paths must be derived from variables or other non-static values. Changes to this argument take effect only after an apply because its value is stored in provider-private state. Paths use dot notation, for example <c>properties.sku.name</c>. Individual list items cannot be targeted, ignore the entire list property instead. Configuration changes at an ignored path will not be sent to Azure until that path is removed from this list. This write-only argument requires Terraform 1.11 or later.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#ignore_body_changes Resource#ignore_body_changes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreBodyChanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IgnoreBodyChanges
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Whether ignore the casing of the property names in the response body.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#ignore_casing Resource#ignore_casing}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreCasing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IgnoreCasing
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether ignore not returned properties like credentials in `body` to suppress plan-diff.</summary>
            /// <remarks>
            /// It's recommend to enable this option when some sensitive properties are not returned in response body, instead of setting them in <c>lifecycle.ignore_changes</c> because it will make the sensitive fields unable to update.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#ignore_missing_property Resource#ignore_missing_property}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreMissingProperty", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IgnoreMissingProperty
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When set to `true`, the provider will ignore properties whose values are `null` in the `body`.</summary>
            /// <remarks>
            /// These properties will not be included in the request body sent to the API, and the difference will not be shown in the plan output.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#ignore_null_property Resource#ignore_null_property}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreNullProperty", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IgnoreNullProperty
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A list of list property paths where items not specified in configuration should be ignored.</summary>
            /// <remarks>
            /// This is intended for partial list management when combined with <c>list_unique_id_property</c> (for example, to avoid perpetual drift from server-side ordering).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#ignore_other_items_in_list Resource#ignore_other_items_in_list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreOtherItemsInList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IgnoreOtherItemsInList
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A mapping of list property paths to the field name used as a unique identifier when comparing and merging list items.</summary>
            /// <remarks>
            /// When not set, list items are matched by a <c>name</c> property (if present) or by list ordering. To match using multiple fields, specify a comma-separated list of field names (e.g., <c>"category, categoryGroup"</c>).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#list_unique_id_property Resource#list_unique_id_property}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "listUniqueIdProperty", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? ListUniqueIdProperty
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>The location of the Azure resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#location Resource#location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Location
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A list of ARM resource IDs which are used to avoid create/modify/delete azapi resources at the same time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#locks Resource#locks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "locks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Locks
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Specifies the name of the azure resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#name Resource#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the azure resource in which this resource is created.</summary>
            /// <remarks>
            /// It supports different kinds of deployment scope for <strong>top level</strong> resources:
            ///
            /// <list type="bullet">
            /// <description>resource group scope: <c>parent_id</c> should be the ID of a resource group, it's recommended to manage a resource group by azurerm_resource_group.</description>
            /// <description>management group scope: <c>parent_id</c> should be the ID of a management group, it's recommended to manage a management group by azurerm_management_group.</description>
            /// <description>extension scope: <c>parent_id</c> should be the ID of the resource you're adding the extension to.</description>
            /// <description>subscription scope: <c>parent_id</c> should be like \x60/subscriptions/00000000-0000-0000-0000-000000000000\x60</description>
            /// <description>tenant scope: <c>parent_id</c> should be /</description>
            /// </list>
            ///
            /// For child level resources, the <c>parent_id</c> should be the ID of its parent resource, for example, subnet resource's <c>parent_id</c> is the ID of the vnet.
            ///
            /// For type <c>Microsoft.Resources/resourceGroups</c>, the <c>parent_id</c> could be omitted, it defaults to subscription ID specified in provider or the default subscription (You could check the default subscription by azure cli command: <c>az account show</c>).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#parent_id Resource#parent_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A mapping of headers to be sent with the read request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#read_headers Resource#read_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? ReadHeaders
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>A mapping of query parameters to be sent with the read request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#read_query_parameters Resource#read_query_parameters}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readQueryParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? ReadQueryParameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Will trigger a replace of the resource when the value changes and is not `null`.</summary>
            /// <remarks>
            /// This can be used by practitioners to force a replace of the resource when certain values change, e.g. changing the SKU of a virtual machine based on the value of variables or locals. The value is a <c>dynamic</c>, so practitioners can compose the input however they wish. For a "break glass" set the value to <c>null</c> to prevent the plan modifier taking effect.
            /// If you have <c>null</c> values that you do want to be tracked as affecting the resource replacement, include these inside an object.
            /// Advanced use cases are possible and resource replacement can be triggered by values external to the resource, for example when a dependent resource changes.
            ///
            /// e.g. to replace a resource when either the SKU or os_type attributes change:
            ///
            /// <code><![CDATA[
            /// resource "azapi_resource" "example" {
            ///   name      = var.name
            ///   type      = "Microsoft.Network/publicIPAddresses@2023-11-01"
            ///   parent_id = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/example"
            ///   body = {
            ///     properties = {
            ///       sku   = var.sku
            ///       zones = var.zones
            ///     }
            ///   }
            ///
            ///   replace_triggers_external_values = [
            ///     var.sku,
            ///     var.zones,
            ///   ]
            /// }
            /// ]]></code>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#replace_triggers_external_values Resource#replace_triggers_external_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replaceTriggersExternalValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, object>? ReplaceTriggersExternalValues
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>?>();
            }

            /// <summary>A list of paths in the current Terraform configuration.</summary>
            /// <remarks>
            /// When the values at these paths change, the resource will be replaced.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#replace_triggers_refs Resource#replace_triggers_refs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replaceTriggersRefs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ReplaceTriggersRefs
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The attribute can accept either a list or a map.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description><strong>List</strong>: A list of paths that need to be exported from the response body. Setting it to <c>["*"]</c> will export the full response body. Here's an example. If it sets to <c>["properties.loginServer", "properties.policies.quarantinePolicy.status"]</c>, it will set the following HCL object to the computed property output.
            ///
            /// <code><![CDATA[
            /// {
            /// 	properties = {
            /// 		loginServer = "registry1.azurecr.io"
            /// 		policies = {
            /// 			quarantinePolicy = {
            /// 				status = "disabled"
            /// 			}
            /// 		}
            /// 	}
            /// }
            /// ]]></code></description>
            /// <description><strong>Map</strong>: A map where the key is the name for the result and the value is a JMESPath query string to filter the response. Here's an example. If it sets to <c>{"login_server": "properties.loginServer", "quarantine_status": "properties.policies.quarantinePolicy.status"}</c>, it will set the following HCL object to the computed property output.
            ///
            /// <code><![CDATA[
            /// {
            /// 	"login_server" = "registry1.azurecr.io"
            /// 	"quarantine_status" = "disabled"
            /// }
            /// ]]></code></description>
            /// </list>
            ///
            /// To learn more about JMESPath, visit <a href="https://jmespath.org/">JMESPath</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#response_export_values Resource#response_export_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "responseExportValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, object>? ResponseExportValues
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>?>();
            }

            /// <summary>The retry object supports the following attributes:.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#retry Resource#retry}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retry", typeJson: "{\"fqn\":\"azapi.resource.ResourceRetry\"}", isOptional: true)]
            public azapi.Resource.IResourceRetry? Retry
            {
                get => GetInstanceProperty<azapi.Resource.IResourceRetry?>();
            }

            /// <summary>Whether enabled the validation on `type` and `body` with embedded schema.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#schema_validation_enabled Resource#schema_validation_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schemaValidationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SchemaValidationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A dynamic attribute that contains the write-only properties of the request body.</summary>
            /// <remarks>
            /// This will be merge-patched to the body to construct the actual request body. If a property is defined in both <c>body</c> and <c>sensitive_body</c>, the <c>sensitive_body</c> value takes precedence.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#sensitive_body Resource#sensitive_body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sensitiveBody", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, object>? SensitiveBody
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>?>();
            }

            /// <summary>A map where the key is the path to the property in `sensitive_body` and the value is the version of the property.</summary>
            /// <remarks>
            /// The key is a string in the format of <c>path.to.property[index].subproperty</c>, where <c>index</c> is the index of the item in an array. When the version is changed, the property will be included in the request body, otherwise it will be omitted from the request body.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#sensitive_body_version Resource#sensitive_body_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sensitiveBodyVersion", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? SensitiveBodyVersion
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>A mapping of tags which should be assigned to the Azure resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#tags Resource#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#timeouts Resource#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azapi.resource.ResourceTimeouts\"}", isOptional: true)]
            public azapi.Resource.IResourceTimeouts? Timeouts
            {
                get => GetInstanceProperty<azapi.Resource.IResourceTimeouts?>();
            }

            /// <summary>A mapping of headers to be sent with the update request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#update_headers Resource#update_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "updateHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? UpdateHeaders
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>A mapping of query parameters to be sent with the update request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#update_query_parameters Resource#update_query_parameters}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "updateQueryParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? UpdateQueryParameters
            {
                get => GetInstanceProperty<object?>();
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
