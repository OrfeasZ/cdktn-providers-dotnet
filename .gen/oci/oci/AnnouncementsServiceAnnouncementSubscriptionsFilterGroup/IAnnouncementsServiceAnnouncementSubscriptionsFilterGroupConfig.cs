using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnnouncementsServiceAnnouncementSubscriptionsFilterGroup
{
    [JsiiInterface(nativeType: typeof(IAnnouncementsServiceAnnouncementSubscriptionsFilterGroupConfig), fullyQualifiedName: "oci.announcementsServiceAnnouncementSubscriptionsFilterGroup.AnnouncementsServiceAnnouncementSubscriptionsFilterGroupConfig")]
    public interface IAnnouncementsServiceAnnouncementSubscriptionsFilterGroupConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#announcement_subscription_id AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#announcement_subscription_id}.</summary>
        [JsiiProperty(name: "announcementSubscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        string AnnouncementSubscriptionId
        {
            get;
        }

        /// <summary>filters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#filters AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#filters}
        /// </remarks>
        [JsiiProperty(name: "filters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.announcementsServiceAnnouncementSubscriptionsFilterGroup.AnnouncementsServiceAnnouncementSubscriptionsFilterGroupFilters\"},\"kind\":\"array\"}}]}}")]
        object Filters
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#name AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#id AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#timeouts AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.announcementsServiceAnnouncementSubscriptionsFilterGroup.AnnouncementsServiceAnnouncementSubscriptionsFilterGroupTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.AnnouncementsServiceAnnouncementSubscriptionsFilterGroup.IAnnouncementsServiceAnnouncementSubscriptionsFilterGroupTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAnnouncementsServiceAnnouncementSubscriptionsFilterGroupConfig), fullyQualifiedName: "oci.announcementsServiceAnnouncementSubscriptionsFilterGroup.AnnouncementsServiceAnnouncementSubscriptionsFilterGroupConfig")]
        internal sealed class _Proxy : DeputyBase, oci.AnnouncementsServiceAnnouncementSubscriptionsFilterGroup.IAnnouncementsServiceAnnouncementSubscriptionsFilterGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#announcement_subscription_id AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#announcement_subscription_id}.</summary>
            [JsiiProperty(name: "announcementSubscriptionId", typeJson: "{\"primitive\":\"string\"}")]
            public string AnnouncementSubscriptionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>filters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#filters AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#filters}
            /// </remarks>
            [JsiiProperty(name: "filters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.announcementsServiceAnnouncementSubscriptionsFilterGroup.AnnouncementsServiceAnnouncementSubscriptionsFilterGroupFilters\"},\"kind\":\"array\"}}]}}")]
            public object Filters
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#name AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#id AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#timeouts AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.announcementsServiceAnnouncementSubscriptionsFilterGroup.AnnouncementsServiceAnnouncementSubscriptionsFilterGroupTimeouts\"}", isOptional: true)]
            public oci.AnnouncementsServiceAnnouncementSubscriptionsFilterGroup.IAnnouncementsServiceAnnouncementSubscriptionsFilterGroupTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.AnnouncementsServiceAnnouncementSubscriptionsFilterGroup.IAnnouncementsServiceAnnouncementSubscriptionsFilterGroupTimeouts?>();
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
