using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeTargetAlertPolicyAssociationUnassociatedTargetMembers
{
    [JsiiInterface(nativeType: typeof(IDataOciDataSafeTargetAlertPolicyAssociationUnassociatedTargetMembersFilter), fullyQualifiedName: "oci.dataOciDataSafeTargetAlertPolicyAssociationUnassociatedTargetMembers.DataOciDataSafeTargetAlertPolicyAssociationUnassociatedTargetMembersFilter")]
    public interface IDataOciDataSafeTargetAlertPolicyAssociationUnassociatedTargetMembersFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/data-sources/data_safe_target_alert_policy_association_unassociated_target_members#name DataOciDataSafeTargetAlertPolicyAssociationUnassociatedTargetMembers#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/data-sources/data_safe_target_alert_policy_association_unassociated_target_members#values DataOciDataSafeTargetAlertPolicyAssociationUnassociatedTargetMembers#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/data-sources/data_safe_target_alert_policy_association_unassociated_target_members#regex DataOciDataSafeTargetAlertPolicyAssociationUnassociatedTargetMembers#regex}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDataSafeTargetAlertPolicyAssociationUnassociatedTargetMembersFilter), fullyQualifiedName: "oci.dataOciDataSafeTargetAlertPolicyAssociationUnassociatedTargetMembers.DataOciDataSafeTargetAlertPolicyAssociationUnassociatedTargetMembersFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDataSafeTargetAlertPolicyAssociationUnassociatedTargetMembers.IDataOciDataSafeTargetAlertPolicyAssociationUnassociatedTargetMembersFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/data-sources/data_safe_target_alert_policy_association_unassociated_target_members#name DataOciDataSafeTargetAlertPolicyAssociationUnassociatedTargetMembers#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/data-sources/data_safe_target_alert_policy_association_unassociated_target_members#values DataOciDataSafeTargetAlertPolicyAssociationUnassociatedTargetMembers#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/data-sources/data_safe_target_alert_policy_association_unassociated_target_members#regex DataOciDataSafeTargetAlertPolicyAssociationUnassociatedTargetMembers#regex}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
