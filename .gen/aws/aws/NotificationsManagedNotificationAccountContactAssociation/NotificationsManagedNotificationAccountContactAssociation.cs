using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NotificationsManagedNotificationAccountContactAssociation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/notifications_managed_notification_account_contact_association aws_notifications_managed_notification_account_contact_association}.</summary>
    [JsiiClass(nativeType: typeof(aws.NotificationsManagedNotificationAccountContactAssociation.NotificationsManagedNotificationAccountContactAssociation), fullyQualifiedName: "aws.notificationsManagedNotificationAccountContactAssociation.NotificationsManagedNotificationAccountContactAssociation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.notificationsManagedNotificationAccountContactAssociation.NotificationsManagedNotificationAccountContactAssociationConfig\"}}]")]
    public class NotificationsManagedNotificationAccountContactAssociation : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/notifications_managed_notification_account_contact_association aws_notifications_managed_notification_account_contact_association} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NotificationsManagedNotificationAccountContactAssociation(Constructs.Construct scope, string id, aws.NotificationsManagedNotificationAccountContactAssociation.INotificationsManagedNotificationAccountContactAssociationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.NotificationsManagedNotificationAccountContactAssociation.INotificationsManagedNotificationAccountContactAssociationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NotificationsManagedNotificationAccountContactAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NotificationsManagedNotificationAccountContactAssociation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a NotificationsManagedNotificationAccountContactAssociation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NotificationsManagedNotificationAccountContactAssociation to import.</param>
        /// <param name="importFromId">The id of the existing NotificationsManagedNotificationAccountContactAssociation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NotificationsManagedNotificationAccountContactAssociation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NotificationsManagedNotificationAccountContactAssociation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/notifications_managed_notification_account_contact_association#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NotificationsManagedNotificationAccountContactAssociation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NotificationsManagedNotificationAccountContactAssociation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.NotificationsManagedNotificationAccountContactAssociation.NotificationsManagedNotificationAccountContactAssociation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.NotificationsManagedNotificationAccountContactAssociation.NotificationsManagedNotificationAccountContactAssociation))!;

        [JsiiOptional]
        [JsiiProperty(name: "contactIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContactIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedNotificationConfigurationArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedNotificationConfigurationArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "contactIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContactIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedNotificationConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedNotificationConfigurationArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
