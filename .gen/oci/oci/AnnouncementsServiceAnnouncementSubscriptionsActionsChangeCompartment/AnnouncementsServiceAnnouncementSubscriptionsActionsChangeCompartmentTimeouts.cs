using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnnouncementsServiceAnnouncementSubscriptionsActionsChangeCompartment
{
    [JsiiByValue(fqn: "oci.announcementsServiceAnnouncementSubscriptionsActionsChangeCompartment.AnnouncementsServiceAnnouncementSubscriptionsActionsChangeCompartmentTimeouts")]
    public class AnnouncementsServiceAnnouncementSubscriptionsActionsChangeCompartmentTimeouts : oci.AnnouncementsServiceAnnouncementSubscriptionsActionsChangeCompartment.IAnnouncementsServiceAnnouncementSubscriptionsActionsChangeCompartmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_actions_change_compartment#create AnnouncementsServiceAnnouncementSubscriptionsActionsChangeCompartment#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_actions_change_compartment#delete AnnouncementsServiceAnnouncementSubscriptionsActionsChangeCompartment#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscriptions_actions_change_compartment#update AnnouncementsServiceAnnouncementSubscriptionsActionsChangeCompartment#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
