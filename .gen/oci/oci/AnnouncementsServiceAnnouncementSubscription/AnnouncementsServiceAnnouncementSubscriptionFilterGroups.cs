using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnnouncementsServiceAnnouncementSubscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.announcementsServiceAnnouncementSubscription.AnnouncementsServiceAnnouncementSubscriptionFilterGroups")]
    public class AnnouncementsServiceAnnouncementSubscriptionFilterGroups : oci.AnnouncementsServiceAnnouncementSubscription.IAnnouncementsServiceAnnouncementSubscriptionFilterGroups
    {
        private object _filters;

        /// <summary>filters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/announcements_service_announcement_subscription#filters AnnouncementsServiceAnnouncementSubscription#filters}
        /// </remarks>
        [JsiiProperty(name: "filters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.announcementsServiceAnnouncementSubscription.AnnouncementsServiceAnnouncementSubscriptionFilterGroupsFilters\"},\"kind\":\"array\"}}]}}")]
        public object Filters
        {
            get => _filters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.AnnouncementsServiceAnnouncementSubscription.IAnnouncementsServiceAnnouncementSubscriptionFilterGroupsFilters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AnnouncementsServiceAnnouncementSubscription.IAnnouncementsServiceAnnouncementSubscriptionFilterGroupsFilters).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AnnouncementsServiceAnnouncementSubscription.IAnnouncementsServiceAnnouncementSubscriptionFilterGroupsFilters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _filters = value;
            }
        }
    }
}
