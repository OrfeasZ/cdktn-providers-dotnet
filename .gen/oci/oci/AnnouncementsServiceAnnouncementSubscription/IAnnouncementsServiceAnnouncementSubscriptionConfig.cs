using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnnouncementsServiceAnnouncementSubscription
{
    [JsiiInterface(nativeType: typeof(IAnnouncementsServiceAnnouncementSubscriptionConfig), fullyQualifiedName: "oci.announcementsServiceAnnouncementSubscription.AnnouncementsServiceAnnouncementSubscriptionConfig")]
    public interface IAnnouncementsServiceAnnouncementSubscriptionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#compartment_id AnnouncementsServiceAnnouncementSubscription#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#display_name AnnouncementsServiceAnnouncementSubscription#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#ons_topic_id AnnouncementsServiceAnnouncementSubscription#ons_topic_id}.</summary>
        [JsiiProperty(name: "onsTopicId", typeJson: "{\"primitive\":\"string\"}")]
        string OnsTopicId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#defined_tags AnnouncementsServiceAnnouncementSubscription#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#description AnnouncementsServiceAnnouncementSubscription#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#filter_groups AnnouncementsServiceAnnouncementSubscription#filter_groups}
        /// </remarks>
        [JsiiProperty(name: "filterGroups", typeJson: "{\"fqn\":\"oci.announcementsServiceAnnouncementSubscription.AnnouncementsServiceAnnouncementSubscriptionFilterGroups\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.AnnouncementsServiceAnnouncementSubscription.IAnnouncementsServiceAnnouncementSubscriptionFilterGroups? FilterGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#freeform_tags AnnouncementsServiceAnnouncementSubscription#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#id AnnouncementsServiceAnnouncementSubscription#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#preferred_language AnnouncementsServiceAnnouncementSubscription#preferred_language}.</summary>
        [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredLanguage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#preferred_time_zone AnnouncementsServiceAnnouncementSubscription#preferred_time_zone}.</summary>
        [JsiiProperty(name: "preferredTimeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredTimeZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#timeouts AnnouncementsServiceAnnouncementSubscription#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.announcementsServiceAnnouncementSubscription.AnnouncementsServiceAnnouncementSubscriptionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.AnnouncementsServiceAnnouncementSubscription.IAnnouncementsServiceAnnouncementSubscriptionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAnnouncementsServiceAnnouncementSubscriptionConfig), fullyQualifiedName: "oci.announcementsServiceAnnouncementSubscription.AnnouncementsServiceAnnouncementSubscriptionConfig")]
        internal sealed class _Proxy : DeputyBase, oci.AnnouncementsServiceAnnouncementSubscription.IAnnouncementsServiceAnnouncementSubscriptionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#compartment_id AnnouncementsServiceAnnouncementSubscription#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#display_name AnnouncementsServiceAnnouncementSubscription#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#ons_topic_id AnnouncementsServiceAnnouncementSubscription#ons_topic_id}.</summary>
            [JsiiProperty(name: "onsTopicId", typeJson: "{\"primitive\":\"string\"}")]
            public string OnsTopicId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#defined_tags AnnouncementsServiceAnnouncementSubscription#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#description AnnouncementsServiceAnnouncementSubscription#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>filter_groups block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#filter_groups AnnouncementsServiceAnnouncementSubscription#filter_groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filterGroups", typeJson: "{\"fqn\":\"oci.announcementsServiceAnnouncementSubscription.AnnouncementsServiceAnnouncementSubscriptionFilterGroups\"}", isOptional: true)]
            public oci.AnnouncementsServiceAnnouncementSubscription.IAnnouncementsServiceAnnouncementSubscriptionFilterGroups? FilterGroups
            {
                get => GetInstanceProperty<oci.AnnouncementsServiceAnnouncementSubscription.IAnnouncementsServiceAnnouncementSubscriptionFilterGroups?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#freeform_tags AnnouncementsServiceAnnouncementSubscription#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#id AnnouncementsServiceAnnouncementSubscription#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#preferred_language AnnouncementsServiceAnnouncementSubscription#preferred_language}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredLanguage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#preferred_time_zone AnnouncementsServiceAnnouncementSubscription#preferred_time_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredTimeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredTimeZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#timeouts AnnouncementsServiceAnnouncementSubscription#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.announcementsServiceAnnouncementSubscription.AnnouncementsServiceAnnouncementSubscriptionTimeouts\"}", isOptional: true)]
            public oci.AnnouncementsServiceAnnouncementSubscription.IAnnouncementsServiceAnnouncementSubscriptionTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.AnnouncementsServiceAnnouncementSubscription.IAnnouncementsServiceAnnouncementSubscriptionTimeouts?>();
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
