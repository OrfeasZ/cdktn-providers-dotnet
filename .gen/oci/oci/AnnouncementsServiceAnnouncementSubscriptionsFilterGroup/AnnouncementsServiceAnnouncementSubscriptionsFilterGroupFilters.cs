using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnnouncementsServiceAnnouncementSubscriptionsFilterGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.announcementsServiceAnnouncementSubscriptionsFilterGroup.AnnouncementsServiceAnnouncementSubscriptionsFilterGroupFilters")]
    public class AnnouncementsServiceAnnouncementSubscriptionsFilterGroupFilters : oci.AnnouncementsServiceAnnouncementSubscriptionsFilterGroup.IAnnouncementsServiceAnnouncementSubscriptionsFilterGroupFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#type AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#value AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
