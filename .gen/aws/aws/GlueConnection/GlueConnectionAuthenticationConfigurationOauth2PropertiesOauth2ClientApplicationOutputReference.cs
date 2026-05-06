using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueConnection
{
    [JsiiClass(nativeType: typeof(aws.GlueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplicationOutputReference), fullyQualifiedName: "aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplicationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplicationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplicationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplicationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplicationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAwsManagedClientApplicationReference")]
        public virtual void ResetAwsManagedClientApplicationReference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserManagedClientApplicationClientId")]
        public virtual void ResetUserManagedClientApplicationClientId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsManagedClientApplicationReferenceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AwsManagedClientApplicationReferenceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userManagedClientApplicationClientIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserManagedClientApplicationClientIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "awsManagedClientApplicationReference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsManagedClientApplicationReference
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userManagedClientApplicationClientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserManagedClientApplicationClientId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication\"}", isOptional: true)]
        public virtual aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication? InternalValue
        {
            get => GetInstanceProperty<aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication?>();
            set => SetInstanceProperty(value);
        }
    }
}
