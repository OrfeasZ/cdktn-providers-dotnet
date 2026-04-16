using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WaitingRoom
{
    [JsiiInterface(nativeType: typeof(IWaitingRoomConfig), fullyQualifiedName: "cloudflare.waitingRoom.WaitingRoomConfig")]
    public interface IWaitingRoomConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The host name to which the waiting room will be applied (no wildcards).</summary>
        /// <remarks>
        /// Please do not include the scheme (http:// or https://). The host and path combination must be unique.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#host WaitingRoom#host}
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        string Host
        {
            get;
        }

        /// <summary>A unique name to identify the waiting room. Only alphanumeric characters, hyphens and underscores are allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#name WaitingRoom#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Sets the number of new users that will be let into the route every minute.</summary>
        /// <remarks>
        /// This value is used as baseline for the number of users that are let in per minute. So it is possible that there is a little more or little less traffic coming to the route based on the traffic patterns at that time around the world.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#new_users_per_minute WaitingRoom#new_users_per_minute}
        /// </remarks>
        [JsiiProperty(name: "newUsersPerMinute", typeJson: "{\"primitive\":\"number\"}")]
        double NewUsersPerMinute
        {
            get;
        }

        /// <summary>Sets the total number of active user sessions on the route at a point in time.</summary>
        /// <remarks>
        /// A route is a combination of host and path on which a waiting room is available. This value is used as a baseline for the total number of active user sessions on the route. It is possible to have a situation where there are more or less active users sessions on the route based on the traffic patterns at that time around the world.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#total_active_users WaitingRoom#total_active_users}
        /// </remarks>
        [JsiiProperty(name: "totalActiveUsers", typeJson: "{\"primitive\":\"number\"}")]
        double TotalActiveUsers
        {
            get;
        }

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#zone_id WaitingRoom#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>Only available for the Waiting Room Advanced subscription.</summary>
        /// <remarks>
        /// Additional hostname and path combinations to which this waiting room will be applied. There is an implied wildcard at the end of the path. The hostname and path combination must be unique to this and all other waiting rooms.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#additional_routes WaitingRoom#additional_routes}
        /// </remarks>
        [JsiiProperty(name: "additionalRoutes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.waitingRoom.WaitingRoomAdditionalRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdditionalRoutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures cookie attributes for the waiting room cookie.</summary>
        /// <remarks>
        /// This encrypted cookie stores a user's status in the waiting room, such as queue position.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#cookie_attributes WaitingRoom#cookie_attributes}
        /// </remarks>
        [JsiiProperty(name: "cookieAttributes", typeJson: "{\"fqn\":\"cloudflare.waitingRoom.WaitingRoomCookieAttributes\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WaitingRoom.IWaitingRoomCookieAttributes? CookieAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Appends a '_' + a custom suffix to the end of Cloudflare Waiting Room's cookie name(__cf_waitingroom).</summary>
        /// <remarks>
        /// If <c>cookie_suffix</c> is "abcd", the cookie name will be <c>__cf_waitingroom_abcd</c>. This field is required if using <c>additional_routes</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#cookie_suffix WaitingRoom#cookie_suffix}
        /// </remarks>
        [JsiiProperty(name: "cookieSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CookieSuffix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Only available for the Waiting Room Advanced subscription.</summary>
        /// <remarks>
        /// This is a template html file that will be rendered at the edge. If no custom_page_html is provided, the default waiting room will be used. The template is based on mustache ( https://mustache.github.io/ ). There are several variables that are evaluated by the Cloudflare edge:
        ///
        /// <list type="number">
        /// <description>{{<c>waitTimeKnown</c>}} Acts like a boolean value that indicates the behavior to take when wait time is not available, for instance when queue_all is <strong>true</strong>.</description>
        /// <description>{{<c>waitTimeFormatted</c>}} Estimated wait time for the user. For example, five minutes. Alternatively, you can use:</description>
        /// <description>{{<c>waitTime</c>}} Number of minutes of estimated wait for a user.</description>
        /// <description>{{<c>waitTimeHours</c>}} Number of hours of estimated wait for a user (<c>Math.floor(waitTime/60)</c>).</description>
        /// <description>{{<c>waitTimeHourMinutes</c>}} Number of minutes above the <c>waitTimeHours</c> value (<c>waitTime%60</c>).</description>
        /// <description>{{<c>queueIsFull</c>}} Changes to <strong>true</strong> when no more people can be added to the queue.</description>
        /// </list>
        ///
        /// To view the full list of variables, look at the <c>cfWaitingRoom</c> object described under the <c>json_response_enabled</c> property in other Waiting Room API calls.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#custom_page_html WaitingRoom#custom_page_html}
        /// </remarks>
        [JsiiProperty(name: "customPageHtml", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomPageHtml
        {
            get
            {
                return null;
            }
        }

        /// <summary>The language of the default page template.</summary>
        /// <remarks>
        /// If no default_template_language is provided, then <c>en-US</c> (English) will be used.
        /// Available values: "en-US", "es-ES", "de-DE", "fr-FR", "it-IT", "ja-JP", "ko-KR", "pt-BR", "zh-CN", "zh-TW", "nl-NL", "pl-PL", "id-ID", "tr-TR", "ar-EG", "ru-RU", "fa-IR", "bg-BG", "hr-HR", "cs-CZ", "da-DK", "fi-FI", "lt-LT", "ms-MY", "nb-NO", "ro-RO", "el-GR", "he-IL", "hi-IN", "hu-HU", "sr-BA", "sk-SK", "sl-SI", "sv-SE", "tl-PH", "th-TH", "uk-UA", "vi-VN".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#default_template_language WaitingRoom#default_template_language}
        /// </remarks>
        [JsiiProperty(name: "defaultTemplateLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultTemplateLanguage
        {
            get
            {
                return null;
            }
        }

        /// <summary>A note that you can use to add more details about the waiting room.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#description WaitingRoom#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Only available for the Waiting Room Advanced subscription.</summary>
        /// <remarks>
        /// Disables automatic renewal of session cookies. If <c>true</c>, an accepted user will have session_duration minutes to browse the site. After that, they will have to go through the waiting room again. If <c>false</c>, a user's session cookie will be automatically renewed on every request.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#disable_session_renewal WaitingRoom#disable_session_renewal}
        /// </remarks>
        [JsiiProperty(name: "disableSessionRenewal", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableSessionRenewal
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of enabled origin commands.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#enabled_origin_commands WaitingRoom#enabled_origin_commands}
        /// </remarks>
        [JsiiProperty(name: "enabledOriginCommands", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EnabledOriginCommands
        {
            get
            {
                return null;
            }
        }

        /// <summary>Only available for the Waiting Room Advanced subscription.</summary>
        /// <remarks>
        /// If <c>true</c>, requests to the waiting room with the header <c>Accept: application/json</c> will receive a JSON response object with information on the user's status in the waiting room as opposed to the configured static HTML page. This JSON response object has one property <c>cfWaitingRoom</c> which is an object containing the following fields:
        ///
        /// <list type="number">
        /// <description><c>inWaitingRoom</c>: Boolean indicating if the user is in the waiting room (always <strong>true</strong>).</description>
        /// <description><c>waitTimeKnown</c>: Boolean indicating if the current estimated wait times are accurate. If <strong>false</strong>, they are not available.</description>
        /// <description><c>waitTime</c>: Valid only when <c>waitTimeKnown</c> is <strong>true</strong>. Integer indicating the current estimated time in minutes the user will wait in the waiting room. When <c>queueingMethod</c> is <strong>random</strong>, this is set to <c>waitTime50Percentile</c>.</description>
        /// <description><c>waitTime25Percentile</c>: Valid only when <c>queueingMethod</c> is <strong>random</strong> and <c>waitTimeKnown</c> is <strong>true</strong>. Integer indicating the current estimated maximum wait time for the 25% of users that gain entry the fastest (25th percentile).</description>
        /// <description><c>waitTime50Percentile</c>: Valid only when <c>queueingMethod</c> is <strong>random</strong> and <c>waitTimeKnown</c> is <strong>true</strong>. Integer indicating the current estimated maximum wait time for the 50% of users that gain entry the fastest (50th percentile). In other words, half of the queued users are expected to let into the origin website before <c>waitTime50Percentile</c> and half are expected to be let in after it.</description>
        /// <description><c>waitTime75Percentile</c>: Valid only when <c>queueingMethod</c> is <strong>random</strong> and <c>waitTimeKnown</c> is <strong>true</strong>. Integer indicating the current estimated maximum wait time for the 75% of users that gain entry the fastest (75th percentile).</description>
        /// <description><c>waitTimeFormatted</c>: String displaying the <c>waitTime</c> formatted in English for users. If <c>waitTimeKnown</c> is <strong>false</strong>, <c>waitTimeFormatted</c> will display <strong>unavailable</strong>.</description>
        /// <description><c>queueIsFull</c>: Boolean indicating if the waiting room's queue is currently full and not accepting new users at the moment.</description>
        /// <description><c>queueAll</c>: Boolean indicating if all users will be queued in the waiting room and no one will be let into the origin website.</description>
        /// <description><c>lastUpdated</c>: String displaying the timestamp as an ISO 8601 string of the user's last attempt to leave the waiting room and be let into the origin website. The user is able to make another attempt after <c>refreshIntervalSeconds</c> past this time. If the user makes a request too soon, it will be ignored and <c>lastUpdated</c> will not change.</description>
        /// <description><c>refreshIntervalSeconds</c>: Integer indicating the number of seconds after <c>lastUpdated</c> until the user is able to make another attempt to leave the waiting room and be let into the origin website. When the <c>queueingMethod</c> is <c>reject</c>, there is no specified refresh time —_it will always be <strong>zero</strong>.</description>
        /// <description><c>queueingMethod</c>: The queueing method currently used by the waiting room. It is either <strong>fifo</strong>, <strong>random</strong>, <strong>passthrough</strong>, or <strong>reject</strong>.</description>
        /// <description><c>isFIFOQueue</c>: Boolean indicating if the waiting room uses a FIFO (First-In-First-Out) queue.</description>
        /// <description><c>isRandomQueue</c>: Boolean indicating if the waiting room uses a Random queue where users gain access randomly.</description>
        /// <description><c>isPassthroughQueue</c>: Boolean indicating if the waiting room uses a passthrough queue. Keep in mind that when passthrough is enabled, this JSON response will only exist when <c>queueAll</c> is <strong>true</strong> or <c>isEventPrequeueing</c> is <strong>true</strong> because in all other cases requests will go directly to the origin.</description>
        /// <description><c>isRejectQueue</c>: Boolean indicating if the waiting room uses a reject queue.</description>
        /// <description><c>isEventActive</c>: Boolean indicating if an event is currently occurring. Events are able to change a waiting room's behavior during a specified period of time. For additional information, look at the event properties <c>prequeue_start_time</c>, <c>event_start_time</c>, and <c>event_end_time</c> in the documentation for creating waiting room events. Events are considered active between these start and end times, as well as during the prequeueing period if it exists.</description>
        /// <description><c>isEventPrequeueing</c>: Valid only when <c>isEventActive</c> is <strong>true</strong>. Boolean indicating if an event is currently prequeueing users before it starts.</description>
        /// <description><c>timeUntilEventStart</c>: Valid only when <c>isEventPrequeueing</c> is <strong>true</strong>. Integer indicating the number of minutes until the event starts.</description>
        /// <description><c>timeUntilEventStartFormatted</c>: String displaying the <c>timeUntilEventStart</c> formatted in English for users. If <c>isEventPrequeueing</c> is <strong>false</strong>, <c>timeUntilEventStartFormatted</c> will display <strong>unavailable</strong>.</description>
        /// <description><c>timeUntilEventEnd</c>: Valid only when <c>isEventActive</c> is <strong>true</strong>. Integer indicating the number of minutes until the event ends.</description>
        /// <description><c>timeUntilEventEndFormatted</c>: String displaying the <c>timeUntilEventEnd</c> formatted in English for users. If <c>isEventActive</c> is <strong>false</strong>, <c>timeUntilEventEndFormatted</c> will display <strong>unavailable</strong>.</description>
        /// <description><c>shuffleAtEventStart</c>: Valid only when <c>isEventActive</c> is <strong>true</strong>. Boolean indicating if the users in the prequeue are shuffled randomly when the event starts.</description>
        /// <description><c>turnstile</c>: Empty when turnstile isn't enabled. String displaying an html tag to display the Turnstile widget. Please add the <c>{{{turnstile}}}</c> tag to the <c>custom_html</c> template to ensure the Turnstile widget appears.</description>
        /// <description><c>infiniteQueue</c>: Boolean indicating whether the response is for a user in the infinite queue.</description>
        /// </list>
        ///
        /// An example cURL to a waiting room could be:
        ///
        /// <code><![CDATA[
        /// curl -X GET "https://example.com/waitingroom" \
        /// 	-H "Accept: application/json"
        /// ]]></code>
        ///
        /// If <c>json_response_enabled</c> is <strong>true</strong> and the request hits the waiting room, an example JSON response when <c>queueingMethod</c> is <strong>fifo</strong> and no event is active could be:
        ///
        /// <code><![CDATA[
        /// {
        /// 	"cfWaitingRoom": {
        /// 		"inWaitingRoom": true,
        /// 		"waitTimeKnown": true,
        /// 		"waitTime": 10,
        /// 		"waitTime25Percentile": 0,
        /// 		"waitTime50Percentile": 0,
        /// 		"waitTime75Percentile": 0,
        /// 		"waitTimeFormatted": "10 minutes",
        /// 		"queueIsFull": false,
        /// 		"queueAll": false,
        /// 		"lastUpdated": "2020-08-03T23:46:00.000Z",
        /// 		"refreshIntervalSeconds": 20,
        /// 		"queueingMethod": "fifo",
        /// 		"isFIFOQueue": true,
        /// 		"isRandomQueue": false,
        /// 		"isPassthroughQueue": false,
        /// 		"isRejectQueue": false,
        /// 		"isEventActive": false,
        /// 		"isEventPrequeueing": false,
        /// 		"timeUntilEventStart": 0,
        /// 		"timeUntilEventStartFormatted": "unavailable",
        /// 		"timeUntilEventEnd": 0,
        /// 		"timeUntilEventEndFormatted": "unavailable",
        /// 		"shuffleAtEventStart": false
        /// 	}
        /// }
        /// ]]></code>
        ///
        /// If <c>json_response_enabled</c> is <strong>true</strong> and the request hits the waiting room, an example JSON response when <c>queueingMethod</c> is <strong>random</strong> and an event is active could be:
        ///
        /// <code><![CDATA[
        /// {
        /// 	"cfWaitingRoom": {
        /// 		"inWaitingRoom": true,
        /// 		"waitTimeKnown": true,
        /// 		"waitTime": 10,
        /// 		"waitTime25Percentile": 5,
        /// 		"waitTime50Percentile": 10,
        /// 		"waitTime75Percentile": 15,
        /// 		"waitTimeFormatted": "5 minutes to 15 minutes",
        /// 		"queueIsFull": false,
        /// 		"queueAll": false,
        /// 		"lastUpdated": "2020-08-03T23:46:00.000Z",
        /// 		"refreshIntervalSeconds": 20,
        /// 		"queueingMethod": "random",
        /// 		"isFIFOQueue": false,
        /// 		"isRandomQueue": true,
        /// 		"isPassthroughQueue": false,
        /// 		"isRejectQueue": false,
        /// 		"isEventActive": true,
        /// 		"isEventPrequeueing": false,
        /// 		"timeUntilEventStart": 0,
        /// 		"timeUntilEventStartFormatted": "unavailable",
        /// 		"timeUntilEventEnd": 15,
        /// 		"timeUntilEventEndFormatted": "15 minutes",
        /// 		"shuffleAtEventStart": true
        /// 	}
        /// }
        /// ]]></code>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#json_response_enabled WaitingRoom#json_response_enabled}
        /// </remarks>
        [JsiiProperty(name: "jsonResponseEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? JsonResponseEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the path within the host to enable the waiting room on.</summary>
        /// <remarks>
        /// The waiting room will be enabled for all subpaths as well. If there are two waiting rooms on the same subpath, the waiting room for the most specific path will be chosen. Wildcards and query parameters are not supported.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#path WaitingRoom#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>If queue_all is `true`, all the traffic that is coming to a route will be sent to the waiting room.</summary>
        /// <remarks>
        /// No new traffic can get to the route once this field is set and estimated time will become unavailable.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#queue_all WaitingRoom#queue_all}
        /// </remarks>
        [JsiiProperty(name: "queueAll", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueueAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the queueing method used by the waiting room.</summary>
        /// <remarks>
        /// Changing this parameter from the <strong>default</strong> queueing method is only available for the Waiting Room Advanced subscription. Regardless of the queueing method, if <c>queue_all</c> is enabled or an event is prequeueing, users in the waiting room will not be accepted to the origin. These users will always see a waiting room page that refreshes automatically. The valid queueing methods are:
        ///
        /// <list type="number">
        /// <description><c>fifo</c> <strong>(default)</strong>: First-In-First-Out queue where customers gain access in the order they arrived.</description>
        /// <description><c>random</c>: Random queue where customers gain access randomly, regardless of arrival time.</description>
        /// <description><c>passthrough</c>: Users will pass directly through the waiting room and into the origin website. As a result, any configured limits will not be respected while this is enabled. This method can be used as an alternative to disabling a waiting room (with <c>suspended</c>) so that analytics are still reported. This can be used if you wish to allow all traffic normally, but want to restrict traffic during a waiting room event, or vice versa.</description>
        /// <description><c>reject</c>: Users will be immediately rejected from the waiting room. As a result, no users will reach the origin website while this is enabled. This can be used if you wish to reject all traffic while performing maintenance, block traffic during a specified period of time (an event), or block traffic while events are not occurring. Consider a waiting room used for vaccine distribution that only allows traffic during sign-up events, and otherwise blocks all traffic. For this case, the waiting room uses <c>reject</c>, and its events override this with <c>fifo</c>, <c>random</c>, or <c>passthrough</c>. When this queueing method is enabled and neither <c>queueAll</c> is enabled nor an event is prequeueing, the waiting room page <strong>will not refresh automatically</strong>.
        /// Available values: "fifo", "random", "passthrough", "reject".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#queueing_method WaitingRoom#queueing_method}
        /// </remarks>
        [JsiiProperty(name: "queueingMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueueingMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>HTTP status code returned to a user while in the queue. Available values: 200, 202, 429.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#queueing_status_code WaitingRoom#queueing_status_code}
        /// </remarks>
        [JsiiProperty(name: "queueingStatusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? QueueingStatusCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Lifetime of a cookie (in minutes) set by Cloudflare for users who get access to the route.</summary>
        /// <remarks>
        /// If a user is not seen by Cloudflare again in that time period, they will be treated as a new user that visits the route.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#session_duration WaitingRoom#session_duration}
        /// </remarks>
        [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SessionDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Suspends or allows traffic going to the waiting room.</summary>
        /// <remarks>
        /// If set to <c>true</c>, the traffic will not go to the waiting room.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#suspended WaitingRoom#suspended}
        /// </remarks>
        [JsiiProperty(name: "suspended", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Suspended
        {
            get
            {
                return null;
            }
        }

        /// <summary>Which action to take when a bot is detected using Turnstile.</summary>
        /// <remarks>
        /// <c>log</c> will
        /// have no impact on queueing behavior, simply keeping track of how many
        /// bots are detected in Waiting Room Analytics. <c>infinite_queue</c> will send
        /// bots to a false queueing state, where they will never reach your
        /// origin. <c>infinite_queue</c> requires Advanced Waiting Room.
        /// Available values: "log", "infinite_queue".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#turnstile_action WaitingRoom#turnstile_action}
        /// </remarks>
        [JsiiProperty(name: "turnstileAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TurnstileAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Which Turnstile widget type to use for detecting bot traffic.</summary>
        /// <remarks>
        /// See
        /// <a href="https://developers.cloudflare.com/turnstile/concepts/widget/#widget-types">the Turnstile documentation</a>
        /// for the definitions of these widget types. Set to <c>off</c> to disable the
        /// Turnstile integration entirely. Setting this to anything other than
        /// <c>off</c> or <c>invisible</c> requires Advanced Waiting Room.
        /// Available values: "off", "invisible", "visible_non_interactive", "visible_managed".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#turnstile_mode WaitingRoom#turnstile_mode}
        /// </remarks>
        [JsiiProperty(name: "turnstileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TurnstileMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWaitingRoomConfig), fullyQualifiedName: "cloudflare.waitingRoom.WaitingRoomConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WaitingRoom.IWaitingRoomConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The host name to which the waiting room will be applied (no wildcards).</summary>
            /// <remarks>
            /// Please do not include the scheme (http:// or https://). The host and path combination must be unique.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#host WaitingRoom#host}
            /// </remarks>
            [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
            public string Host
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A unique name to identify the waiting room. Only alphanumeric characters, hyphens and underscores are allowed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#name WaitingRoom#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the number of new users that will be let into the route every minute.</summary>
            /// <remarks>
            /// This value is used as baseline for the number of users that are let in per minute. So it is possible that there is a little more or little less traffic coming to the route based on the traffic patterns at that time around the world.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#new_users_per_minute WaitingRoom#new_users_per_minute}
            /// </remarks>
            [JsiiProperty(name: "newUsersPerMinute", typeJson: "{\"primitive\":\"number\"}")]
            public double NewUsersPerMinute
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets the total number of active user sessions on the route at a point in time.</summary>
            /// <remarks>
            /// A route is a combination of host and path on which a waiting room is available. This value is used as a baseline for the total number of active user sessions on the route. It is possible to have a situation where there are more or less active users sessions on the route based on the traffic patterns at that time around the world.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#total_active_users WaitingRoom#total_active_users}
            /// </remarks>
            [JsiiProperty(name: "totalActiveUsers", typeJson: "{\"primitive\":\"number\"}")]
            public double TotalActiveUsers
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#zone_id WaitingRoom#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Only available for the Waiting Room Advanced subscription.</summary>
            /// <remarks>
            /// Additional hostname and path combinations to which this waiting room will be applied. There is an implied wildcard at the end of the path. The hostname and path combination must be unique to this and all other waiting rooms.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#additional_routes WaitingRoom#additional_routes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalRoutes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.waitingRoom.WaitingRoomAdditionalRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AdditionalRoutes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures cookie attributes for the waiting room cookie.</summary>
            /// <remarks>
            /// This encrypted cookie stores a user's status in the waiting room, such as queue position.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#cookie_attributes WaitingRoom#cookie_attributes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cookieAttributes", typeJson: "{\"fqn\":\"cloudflare.waitingRoom.WaitingRoomCookieAttributes\"}", isOptional: true)]
            public cloudflare.WaitingRoom.IWaitingRoomCookieAttributes? CookieAttributes
            {
                get => GetInstanceProperty<cloudflare.WaitingRoom.IWaitingRoomCookieAttributes?>();
            }

            /// <summary>Appends a '_' + a custom suffix to the end of Cloudflare Waiting Room's cookie name(__cf_waitingroom).</summary>
            /// <remarks>
            /// If <c>cookie_suffix</c> is "abcd", the cookie name will be <c>__cf_waitingroom_abcd</c>. This field is required if using <c>additional_routes</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#cookie_suffix WaitingRoom#cookie_suffix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cookieSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CookieSuffix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Only available for the Waiting Room Advanced subscription.</summary>
            /// <remarks>
            /// This is a template html file that will be rendered at the edge. If no custom_page_html is provided, the default waiting room will be used. The template is based on mustache ( https://mustache.github.io/ ). There are several variables that are evaluated by the Cloudflare edge:
            ///
            /// <list type="number">
            /// <description>{{<c>waitTimeKnown</c>}} Acts like a boolean value that indicates the behavior to take when wait time is not available, for instance when queue_all is <strong>true</strong>.</description>
            /// <description>{{<c>waitTimeFormatted</c>}} Estimated wait time for the user. For example, five minutes. Alternatively, you can use:</description>
            /// <description>{{<c>waitTime</c>}} Number of minutes of estimated wait for a user.</description>
            /// <description>{{<c>waitTimeHours</c>}} Number of hours of estimated wait for a user (<c>Math.floor(waitTime/60)</c>).</description>
            /// <description>{{<c>waitTimeHourMinutes</c>}} Number of minutes above the <c>waitTimeHours</c> value (<c>waitTime%60</c>).</description>
            /// <description>{{<c>queueIsFull</c>}} Changes to <strong>true</strong> when no more people can be added to the queue.</description>
            /// </list>
            ///
            /// To view the full list of variables, look at the <c>cfWaitingRoom</c> object described under the <c>json_response_enabled</c> property in other Waiting Room API calls.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#custom_page_html WaitingRoom#custom_page_html}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customPageHtml", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomPageHtml
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The language of the default page template.</summary>
            /// <remarks>
            /// If no default_template_language is provided, then <c>en-US</c> (English) will be used.
            /// Available values: "en-US", "es-ES", "de-DE", "fr-FR", "it-IT", "ja-JP", "ko-KR", "pt-BR", "zh-CN", "zh-TW", "nl-NL", "pl-PL", "id-ID", "tr-TR", "ar-EG", "ru-RU", "fa-IR", "bg-BG", "hr-HR", "cs-CZ", "da-DK", "fi-FI", "lt-LT", "ms-MY", "nb-NO", "ro-RO", "el-GR", "he-IL", "hi-IN", "hu-HU", "sr-BA", "sk-SK", "sl-SI", "sv-SE", "tl-PH", "th-TH", "uk-UA", "vi-VN".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#default_template_language WaitingRoom#default_template_language}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultTemplateLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultTemplateLanguage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A note that you can use to add more details about the waiting room.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#description WaitingRoom#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Only available for the Waiting Room Advanced subscription.</summary>
            /// <remarks>
            /// Disables automatic renewal of session cookies. If <c>true</c>, an accepted user will have session_duration minutes to browse the site. After that, they will have to go through the waiting room again. If <c>false</c>, a user's session cookie will be automatically renewed on every request.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#disable_session_renewal WaitingRoom#disable_session_renewal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableSessionRenewal", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableSessionRenewal
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A list of enabled origin commands.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#enabled_origin_commands WaitingRoom#enabled_origin_commands}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabledOriginCommands", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EnabledOriginCommands
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Only available for the Waiting Room Advanced subscription.</summary>
            /// <remarks>
            /// If <c>true</c>, requests to the waiting room with the header <c>Accept: application/json</c> will receive a JSON response object with information on the user's status in the waiting room as opposed to the configured static HTML page. This JSON response object has one property <c>cfWaitingRoom</c> which is an object containing the following fields:
            ///
            /// <list type="number">
            /// <description><c>inWaitingRoom</c>: Boolean indicating if the user is in the waiting room (always <strong>true</strong>).</description>
            /// <description><c>waitTimeKnown</c>: Boolean indicating if the current estimated wait times are accurate. If <strong>false</strong>, they are not available.</description>
            /// <description><c>waitTime</c>: Valid only when <c>waitTimeKnown</c> is <strong>true</strong>. Integer indicating the current estimated time in minutes the user will wait in the waiting room. When <c>queueingMethod</c> is <strong>random</strong>, this is set to <c>waitTime50Percentile</c>.</description>
            /// <description><c>waitTime25Percentile</c>: Valid only when <c>queueingMethod</c> is <strong>random</strong> and <c>waitTimeKnown</c> is <strong>true</strong>. Integer indicating the current estimated maximum wait time for the 25% of users that gain entry the fastest (25th percentile).</description>
            /// <description><c>waitTime50Percentile</c>: Valid only when <c>queueingMethod</c> is <strong>random</strong> and <c>waitTimeKnown</c> is <strong>true</strong>. Integer indicating the current estimated maximum wait time for the 50% of users that gain entry the fastest (50th percentile). In other words, half of the queued users are expected to let into the origin website before <c>waitTime50Percentile</c> and half are expected to be let in after it.</description>
            /// <description><c>waitTime75Percentile</c>: Valid only when <c>queueingMethod</c> is <strong>random</strong> and <c>waitTimeKnown</c> is <strong>true</strong>. Integer indicating the current estimated maximum wait time for the 75% of users that gain entry the fastest (75th percentile).</description>
            /// <description><c>waitTimeFormatted</c>: String displaying the <c>waitTime</c> formatted in English for users. If <c>waitTimeKnown</c> is <strong>false</strong>, <c>waitTimeFormatted</c> will display <strong>unavailable</strong>.</description>
            /// <description><c>queueIsFull</c>: Boolean indicating if the waiting room's queue is currently full and not accepting new users at the moment.</description>
            /// <description><c>queueAll</c>: Boolean indicating if all users will be queued in the waiting room and no one will be let into the origin website.</description>
            /// <description><c>lastUpdated</c>: String displaying the timestamp as an ISO 8601 string of the user's last attempt to leave the waiting room and be let into the origin website. The user is able to make another attempt after <c>refreshIntervalSeconds</c> past this time. If the user makes a request too soon, it will be ignored and <c>lastUpdated</c> will not change.</description>
            /// <description><c>refreshIntervalSeconds</c>: Integer indicating the number of seconds after <c>lastUpdated</c> until the user is able to make another attempt to leave the waiting room and be let into the origin website. When the <c>queueingMethod</c> is <c>reject</c>, there is no specified refresh time —_it will always be <strong>zero</strong>.</description>
            /// <description><c>queueingMethod</c>: The queueing method currently used by the waiting room. It is either <strong>fifo</strong>, <strong>random</strong>, <strong>passthrough</strong>, or <strong>reject</strong>.</description>
            /// <description><c>isFIFOQueue</c>: Boolean indicating if the waiting room uses a FIFO (First-In-First-Out) queue.</description>
            /// <description><c>isRandomQueue</c>: Boolean indicating if the waiting room uses a Random queue where users gain access randomly.</description>
            /// <description><c>isPassthroughQueue</c>: Boolean indicating if the waiting room uses a passthrough queue. Keep in mind that when passthrough is enabled, this JSON response will only exist when <c>queueAll</c> is <strong>true</strong> or <c>isEventPrequeueing</c> is <strong>true</strong> because in all other cases requests will go directly to the origin.</description>
            /// <description><c>isRejectQueue</c>: Boolean indicating if the waiting room uses a reject queue.</description>
            /// <description><c>isEventActive</c>: Boolean indicating if an event is currently occurring. Events are able to change a waiting room's behavior during a specified period of time. For additional information, look at the event properties <c>prequeue_start_time</c>, <c>event_start_time</c>, and <c>event_end_time</c> in the documentation for creating waiting room events. Events are considered active between these start and end times, as well as during the prequeueing period if it exists.</description>
            /// <description><c>isEventPrequeueing</c>: Valid only when <c>isEventActive</c> is <strong>true</strong>. Boolean indicating if an event is currently prequeueing users before it starts.</description>
            /// <description><c>timeUntilEventStart</c>: Valid only when <c>isEventPrequeueing</c> is <strong>true</strong>. Integer indicating the number of minutes until the event starts.</description>
            /// <description><c>timeUntilEventStartFormatted</c>: String displaying the <c>timeUntilEventStart</c> formatted in English for users. If <c>isEventPrequeueing</c> is <strong>false</strong>, <c>timeUntilEventStartFormatted</c> will display <strong>unavailable</strong>.</description>
            /// <description><c>timeUntilEventEnd</c>: Valid only when <c>isEventActive</c> is <strong>true</strong>. Integer indicating the number of minutes until the event ends.</description>
            /// <description><c>timeUntilEventEndFormatted</c>: String displaying the <c>timeUntilEventEnd</c> formatted in English for users. If <c>isEventActive</c> is <strong>false</strong>, <c>timeUntilEventEndFormatted</c> will display <strong>unavailable</strong>.</description>
            /// <description><c>shuffleAtEventStart</c>: Valid only when <c>isEventActive</c> is <strong>true</strong>. Boolean indicating if the users in the prequeue are shuffled randomly when the event starts.</description>
            /// <description><c>turnstile</c>: Empty when turnstile isn't enabled. String displaying an html tag to display the Turnstile widget. Please add the <c>{{{turnstile}}}</c> tag to the <c>custom_html</c> template to ensure the Turnstile widget appears.</description>
            /// <description><c>infiniteQueue</c>: Boolean indicating whether the response is for a user in the infinite queue.</description>
            /// </list>
            ///
            /// An example cURL to a waiting room could be:
            ///
            /// <code><![CDATA[
            /// curl -X GET "https://example.com/waitingroom" \
            /// 	-H "Accept: application/json"
            /// ]]></code>
            ///
            /// If <c>json_response_enabled</c> is <strong>true</strong> and the request hits the waiting room, an example JSON response when <c>queueingMethod</c> is <strong>fifo</strong> and no event is active could be:
            ///
            /// <code><![CDATA[
            /// {
            /// 	"cfWaitingRoom": {
            /// 		"inWaitingRoom": true,
            /// 		"waitTimeKnown": true,
            /// 		"waitTime": 10,
            /// 		"waitTime25Percentile": 0,
            /// 		"waitTime50Percentile": 0,
            /// 		"waitTime75Percentile": 0,
            /// 		"waitTimeFormatted": "10 minutes",
            /// 		"queueIsFull": false,
            /// 		"queueAll": false,
            /// 		"lastUpdated": "2020-08-03T23:46:00.000Z",
            /// 		"refreshIntervalSeconds": 20,
            /// 		"queueingMethod": "fifo",
            /// 		"isFIFOQueue": true,
            /// 		"isRandomQueue": false,
            /// 		"isPassthroughQueue": false,
            /// 		"isRejectQueue": false,
            /// 		"isEventActive": false,
            /// 		"isEventPrequeueing": false,
            /// 		"timeUntilEventStart": 0,
            /// 		"timeUntilEventStartFormatted": "unavailable",
            /// 		"timeUntilEventEnd": 0,
            /// 		"timeUntilEventEndFormatted": "unavailable",
            /// 		"shuffleAtEventStart": false
            /// 	}
            /// }
            /// ]]></code>
            ///
            /// If <c>json_response_enabled</c> is <strong>true</strong> and the request hits the waiting room, an example JSON response when <c>queueingMethod</c> is <strong>random</strong> and an event is active could be:
            ///
            /// <code><![CDATA[
            /// {
            /// 	"cfWaitingRoom": {
            /// 		"inWaitingRoom": true,
            /// 		"waitTimeKnown": true,
            /// 		"waitTime": 10,
            /// 		"waitTime25Percentile": 5,
            /// 		"waitTime50Percentile": 10,
            /// 		"waitTime75Percentile": 15,
            /// 		"waitTimeFormatted": "5 minutes to 15 minutes",
            /// 		"queueIsFull": false,
            /// 		"queueAll": false,
            /// 		"lastUpdated": "2020-08-03T23:46:00.000Z",
            /// 		"refreshIntervalSeconds": 20,
            /// 		"queueingMethod": "random",
            /// 		"isFIFOQueue": false,
            /// 		"isRandomQueue": true,
            /// 		"isPassthroughQueue": false,
            /// 		"isRejectQueue": false,
            /// 		"isEventActive": true,
            /// 		"isEventPrequeueing": false,
            /// 		"timeUntilEventStart": 0,
            /// 		"timeUntilEventStartFormatted": "unavailable",
            /// 		"timeUntilEventEnd": 15,
            /// 		"timeUntilEventEndFormatted": "15 minutes",
            /// 		"shuffleAtEventStart": true
            /// 	}
            /// }
            /// ]]></code>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#json_response_enabled WaitingRoom#json_response_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jsonResponseEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? JsonResponseEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the path within the host to enable the waiting room on.</summary>
            /// <remarks>
            /// The waiting room will be enabled for all subpaths as well. If there are two waiting rooms on the same subpath, the waiting room for the most specific path will be chosen. Wildcards and query parameters are not supported.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#path WaitingRoom#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If queue_all is `true`, all the traffic that is coming to a route will be sent to the waiting room.</summary>
            /// <remarks>
            /// No new traffic can get to the route once this field is set and estimated time will become unavailable.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#queue_all WaitingRoom#queue_all}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queueAll", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? QueueAll
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the queueing method used by the waiting room.</summary>
            /// <remarks>
            /// Changing this parameter from the <strong>default</strong> queueing method is only available for the Waiting Room Advanced subscription. Regardless of the queueing method, if <c>queue_all</c> is enabled or an event is prequeueing, users in the waiting room will not be accepted to the origin. These users will always see a waiting room page that refreshes automatically. The valid queueing methods are:
            ///
            /// <list type="number">
            /// <description><c>fifo</c> <strong>(default)</strong>: First-In-First-Out queue where customers gain access in the order they arrived.</description>
            /// <description><c>random</c>: Random queue where customers gain access randomly, regardless of arrival time.</description>
            /// <description><c>passthrough</c>: Users will pass directly through the waiting room and into the origin website. As a result, any configured limits will not be respected while this is enabled. This method can be used as an alternative to disabling a waiting room (with <c>suspended</c>) so that analytics are still reported. This can be used if you wish to allow all traffic normally, but want to restrict traffic during a waiting room event, or vice versa.</description>
            /// <description><c>reject</c>: Users will be immediately rejected from the waiting room. As a result, no users will reach the origin website while this is enabled. This can be used if you wish to reject all traffic while performing maintenance, block traffic during a specified period of time (an event), or block traffic while events are not occurring. Consider a waiting room used for vaccine distribution that only allows traffic during sign-up events, and otherwise blocks all traffic. For this case, the waiting room uses <c>reject</c>, and its events override this with <c>fifo</c>, <c>random</c>, or <c>passthrough</c>. When this queueing method is enabled and neither <c>queueAll</c> is enabled nor an event is prequeueing, the waiting room page <strong>will not refresh automatically</strong>.
            /// Available values: "fifo", "random", "passthrough", "reject".</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#queueing_method WaitingRoom#queueing_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queueingMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueueingMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>HTTP status code returned to a user while in the queue. Available values: 200, 202, 429.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#queueing_status_code WaitingRoom#queueing_status_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queueingStatusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? QueueingStatusCode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Lifetime of a cookie (in minutes) set by Cloudflare for users who get access to the route.</summary>
            /// <remarks>
            /// If a user is not seen by Cloudflare again in that time period, they will be treated as a new user that visits the route.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#session_duration WaitingRoom#session_duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SessionDuration
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Suspends or allows traffic going to the waiting room.</summary>
            /// <remarks>
            /// If set to <c>true</c>, the traffic will not go to the waiting room.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#suspended WaitingRoom#suspended}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "suspended", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Suspended
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Which action to take when a bot is detected using Turnstile.</summary>
            /// <remarks>
            /// <c>log</c> will
            /// have no impact on queueing behavior, simply keeping track of how many
            /// bots are detected in Waiting Room Analytics. <c>infinite_queue</c> will send
            /// bots to a false queueing state, where they will never reach your
            /// origin. <c>infinite_queue</c> requires Advanced Waiting Room.
            /// Available values: "log", "infinite_queue".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#turnstile_action WaitingRoom#turnstile_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "turnstileAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TurnstileAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Which Turnstile widget type to use for detecting bot traffic.</summary>
            /// <remarks>
            /// See
            /// <a href="https://developers.cloudflare.com/turnstile/concepts/widget/#widget-types">the Turnstile documentation</a>
            /// for the definitions of these widget types. Set to <c>off</c> to disable the
            /// Turnstile integration entirely. Setting this to anything other than
            /// <c>off</c> or <c>invisible</c> requires Advanced Waiting Room.
            /// Available values: "off", "invisible", "visible_non_interactive", "visible_managed".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#turnstile_mode WaitingRoom#turnstile_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "turnstileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TurnstileMode
            {
                get => GetInstanceProperty<string?>();
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
