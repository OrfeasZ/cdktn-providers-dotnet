using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueConnection
{
    [JsiiClass(nativeType: typeof(aws.GlueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2CredentialsOutputReference), fullyQualifiedName: "aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2CredentialsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2CredentialsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2CredentialsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2CredentialsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2CredentialsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccessToken")]
        public virtual void ResetAccessToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJwtToken")]
        public virtual void ResetJwtToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRefreshToken")]
        public virtual void ResetRefreshToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserManagedClientApplicationClientSecret")]
        public virtual void ResetUserManagedClientApplicationClientSecret()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jwtTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JwtTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "refreshTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RefreshTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userManagedClientApplicationClientSecretInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserManagedClientApplicationClientSecretInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accessToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessToken
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jwtToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JwtToken
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "refreshToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefreshToken
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userManagedClientApplicationClientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserManagedClientApplicationClientSecret
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2Credentials\"}", isOptional: true)]
        public virtual aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2Credentials? InternalValue
        {
            get => GetInstanceProperty<aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2Credentials?>();
            set => SetInstanceProperty(value);
        }
    }
}
