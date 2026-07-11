using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    [JsiiByValue(fqn: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyRequestorSettings")]
    public class AccessPackageAssignmentPolicyRequestorSettings : azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyRequestorSettings
    {
        private object? _requestor;

        /// <summary>requestor block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#requestor AccessPackageAssignmentPolicy#requestor}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyRequestorSettingsRequestor" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestor", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyRequestorSettingsRequestor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Requestor
        {
            get => _requestor;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyRequestorSettingsRequestor[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyRequestorSettingsRequestor).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestor = value;
            }
        }

        private object? _requestsAccepted;

        /// <summary>Whether to accept requests now, when disabled, no new requests can be made using this policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#requests_accepted AccessPackageAssignmentPolicy#requests_accepted}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestsAccepted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RequestsAccepted
        {
            get => _requestsAccepted;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestsAccepted = value;
            }
        }

        /// <summary>Specify the scopes of the requestors.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#scope_type AccessPackageAssignmentPolicy#scope_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scopeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScopeType
        {
            get;
            set;
        }
    }
}
