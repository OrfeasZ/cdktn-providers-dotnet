using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CapacityManagementOccCapacityRequest
{
    [JsiiInterface(nativeType: typeof(ICapacityManagementOccCapacityRequestConfig), fullyQualifiedName: "oci.capacityManagementOccCapacityRequest.CapacityManagementOccCapacityRequestConfig")]
    public interface ICapacityManagementOccCapacityRequestConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#compartment_id CapacityManagementOccCapacityRequest#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#date_expected_capacity_handover CapacityManagementOccCapacityRequest#date_expected_capacity_handover}.</summary>
        [JsiiProperty(name: "dateExpectedCapacityHandover", typeJson: "{\"primitive\":\"string\"}")]
        string DateExpectedCapacityHandover
        {
            get;
        }

        /// <summary>details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#details CapacityManagementOccCapacityRequest#details}
        /// </remarks>
        [JsiiProperty(name: "details", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.capacityManagementOccCapacityRequest.CapacityManagementOccCapacityRequestDetails\"},\"kind\":\"array\"}}]}}")]
        object Details
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#display_name CapacityManagementOccCapacityRequest#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#namespace CapacityManagementOccCapacityRequest#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#occ_availability_catalog_id CapacityManagementOccCapacityRequest#occ_availability_catalog_id}.</summary>
        [JsiiProperty(name: "occAvailabilityCatalogId", typeJson: "{\"primitive\":\"string\"}")]
        string OccAvailabilityCatalogId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#region CapacityManagementOccCapacityRequest#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#availability_domain CapacityManagementOccCapacityRequest#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#defined_tags CapacityManagementOccCapacityRequest#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#description CapacityManagementOccCapacityRequest#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#freeform_tags CapacityManagementOccCapacityRequest#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#id CapacityManagementOccCapacityRequest#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#lifecycle_details CapacityManagementOccCapacityRequest#lifecycle_details}.</summary>
        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LifecycleDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>patch_operations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#patch_operations CapacityManagementOccCapacityRequest#patch_operations}
        /// </remarks>
        [JsiiProperty(name: "patchOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.capacityManagementOccCapacityRequest.CapacityManagementOccCapacityRequestPatchOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PatchOperations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#request_state CapacityManagementOccCapacityRequest#request_state}.</summary>
        [JsiiProperty(name: "requestState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequestState
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#request_type CapacityManagementOccCapacityRequest#request_type}.</summary>
        [JsiiProperty(name: "requestType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequestType
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#timeouts CapacityManagementOccCapacityRequest#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.capacityManagementOccCapacityRequest.CapacityManagementOccCapacityRequestTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CapacityManagementOccCapacityRequest.ICapacityManagementOccCapacityRequestTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICapacityManagementOccCapacityRequestConfig), fullyQualifiedName: "oci.capacityManagementOccCapacityRequest.CapacityManagementOccCapacityRequestConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CapacityManagementOccCapacityRequest.ICapacityManagementOccCapacityRequestConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#compartment_id CapacityManagementOccCapacityRequest#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#date_expected_capacity_handover CapacityManagementOccCapacityRequest#date_expected_capacity_handover}.</summary>
            [JsiiProperty(name: "dateExpectedCapacityHandover", typeJson: "{\"primitive\":\"string\"}")]
            public string DateExpectedCapacityHandover
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#details CapacityManagementOccCapacityRequest#details}
            /// </remarks>
            [JsiiProperty(name: "details", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.capacityManagementOccCapacityRequest.CapacityManagementOccCapacityRequestDetails\"},\"kind\":\"array\"}}]}}")]
            public object Details
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#display_name CapacityManagementOccCapacityRequest#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#namespace CapacityManagementOccCapacityRequest#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#occ_availability_catalog_id CapacityManagementOccCapacityRequest#occ_availability_catalog_id}.</summary>
            [JsiiProperty(name: "occAvailabilityCatalogId", typeJson: "{\"primitive\":\"string\"}")]
            public string OccAvailabilityCatalogId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#region CapacityManagementOccCapacityRequest#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#availability_domain CapacityManagementOccCapacityRequest#availability_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#defined_tags CapacityManagementOccCapacityRequest#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#description CapacityManagementOccCapacityRequest#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#freeform_tags CapacityManagementOccCapacityRequest#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#id CapacityManagementOccCapacityRequest#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#lifecycle_details CapacityManagementOccCapacityRequest#lifecycle_details}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LifecycleDetails
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>patch_operations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#patch_operations CapacityManagementOccCapacityRequest#patch_operations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "patchOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.capacityManagementOccCapacityRequest.CapacityManagementOccCapacityRequestPatchOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PatchOperations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#request_state CapacityManagementOccCapacityRequest#request_state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requestState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestState
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#request_type CapacityManagementOccCapacityRequest#request_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requestType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#timeouts CapacityManagementOccCapacityRequest#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.capacityManagementOccCapacityRequest.CapacityManagementOccCapacityRequestTimeouts\"}", isOptional: true)]
            public oci.CapacityManagementOccCapacityRequest.ICapacityManagementOccCapacityRequestTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.CapacityManagementOccCapacityRequest.ICapacityManagementOccCapacityRequestTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
