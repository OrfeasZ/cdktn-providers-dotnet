using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NotificationsManagedNotificationAccountContactAssociation
{
    [JsiiInterface(nativeType: typeof(INotificationsManagedNotificationAccountContactAssociationConfig), fullyQualifiedName: "aws.notificationsManagedNotificationAccountContactAssociation.NotificationsManagedNotificationAccountContactAssociationConfig")]
    public interface INotificationsManagedNotificationAccountContactAssociationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/notifications_managed_notification_account_contact_association#contact_identifier NotificationsManagedNotificationAccountContactAssociation#contact_identifier}.</summary>
        [JsiiProperty(name: "contactIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string ContactIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/notifications_managed_notification_account_contact_association#managed_notification_configuration_arn NotificationsManagedNotificationAccountContactAssociation#managed_notification_configuration_arn}.</summary>
        [JsiiProperty(name: "managedNotificationConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        string ManagedNotificationConfigurationArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INotificationsManagedNotificationAccountContactAssociationConfig), fullyQualifiedName: "aws.notificationsManagedNotificationAccountContactAssociation.NotificationsManagedNotificationAccountContactAssociationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.NotificationsManagedNotificationAccountContactAssociation.INotificationsManagedNotificationAccountContactAssociationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/notifications_managed_notification_account_contact_association#contact_identifier NotificationsManagedNotificationAccountContactAssociation#contact_identifier}.</summary>
            [JsiiProperty(name: "contactIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string ContactIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/notifications_managed_notification_account_contact_association#managed_notification_configuration_arn NotificationsManagedNotificationAccountContactAssociation#managed_notification_configuration_arn}.</summary>
            [JsiiProperty(name: "managedNotificationConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ManagedNotificationConfigurationArn
            {
                get => GetInstanceProperty<string>()!;
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
