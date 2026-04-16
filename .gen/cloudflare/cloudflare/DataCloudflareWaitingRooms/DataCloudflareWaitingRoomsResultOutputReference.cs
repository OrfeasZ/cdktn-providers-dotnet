using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWaitingRooms
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWaitingRooms.DataCloudflareWaitingRoomsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWaitingRooms.DataCloudflareWaitingRoomsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareWaitingRoomsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareWaitingRoomsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWaitingRoomsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWaitingRoomsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "additionalRoutes", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWaitingRooms.DataCloudflareWaitingRoomsResultAdditionalRoutesList\"}")]
        public virtual cloudflare.DataCloudflareWaitingRooms.DataCloudflareWaitingRoomsResultAdditionalRoutesList AdditionalRoutes
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWaitingRooms.DataCloudflareWaitingRoomsResultAdditionalRoutesList>()!;
        }

        [JsiiProperty(name: "cookieAttributes", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWaitingRooms.DataCloudflareWaitingRoomsResultCookieAttributesOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWaitingRooms.DataCloudflareWaitingRoomsResultCookieAttributesOutputReference CookieAttributes
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWaitingRooms.DataCloudflareWaitingRoomsResultCookieAttributesOutputReference>()!;
        }

        [JsiiProperty(name: "cookieSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CookieSuffix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customPageHtml", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomPageHtml
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultTemplateLanguage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultTemplateLanguage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disableSessionRenewal", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DisableSessionRenewal
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enabledOriginCommands", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EnabledOriginCommands
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Host
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jsonResponseEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable JsonResponseEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "newUsersPerMinute", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NewUsersPerMinute
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nextEventPrequeueStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextEventPrequeueStartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nextEventStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextEventStartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "queueAll", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable QueueAll
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "queueingMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueueingMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "queueingStatusCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QueueingStatusCode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SessionDuration
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "suspended", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Suspended
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "totalActiveUsers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalActiveUsers
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "turnstileAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TurnstileAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "turnstileMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TurnstileMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWaitingRooms.DataCloudflareWaitingRoomsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWaitingRooms.IDataCloudflareWaitingRoomsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWaitingRooms.IDataCloudflareWaitingRoomsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
