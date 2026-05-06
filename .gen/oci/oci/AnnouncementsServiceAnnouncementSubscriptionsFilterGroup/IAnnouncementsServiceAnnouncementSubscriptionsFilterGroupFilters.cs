using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnnouncementsServiceAnnouncementSubscriptionsFilterGroup
{
    [JsiiInterface(nativeType: typeof(IAnnouncementsServiceAnnouncementSubscriptionsFilterGroupFilters), fullyQualifiedName: "oci.announcementsServiceAnnouncementSubscriptionsFilterGroup.AnnouncementsServiceAnnouncementSubscriptionsFilterGroupFilters")]
    public interface IAnnouncementsServiceAnnouncementSubscriptionsFilterGroupFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#type AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#value AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAnnouncementsServiceAnnouncementSubscriptionsFilterGroupFilters), fullyQualifiedName: "oci.announcementsServiceAnnouncementSubscriptionsFilterGroup.AnnouncementsServiceAnnouncementSubscriptionsFilterGroupFilters")]
        internal sealed class _Proxy : DeputyBase, oci.AnnouncementsServiceAnnouncementSubscriptionsFilterGroup.IAnnouncementsServiceAnnouncementSubscriptionsFilterGroupFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#type AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#value AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
