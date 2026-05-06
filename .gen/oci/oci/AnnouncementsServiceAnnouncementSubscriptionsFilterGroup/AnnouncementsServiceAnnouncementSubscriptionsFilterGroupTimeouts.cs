using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnnouncementsServiceAnnouncementSubscriptionsFilterGroup
{
    [JsiiByValue(fqn: "oci.announcementsServiceAnnouncementSubscriptionsFilterGroup.AnnouncementsServiceAnnouncementSubscriptionsFilterGroupTimeouts")]
    public class AnnouncementsServiceAnnouncementSubscriptionsFilterGroupTimeouts : oci.AnnouncementsServiceAnnouncementSubscriptionsFilterGroup.IAnnouncementsServiceAnnouncementSubscriptionsFilterGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#create AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#delete AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_filter_group#update AnnouncementsServiceAnnouncementSubscriptionsFilterGroup#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
