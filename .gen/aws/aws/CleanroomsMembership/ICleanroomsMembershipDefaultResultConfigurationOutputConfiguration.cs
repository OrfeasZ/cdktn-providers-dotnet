using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CleanroomsMembership
{
    [JsiiInterface(nativeType: typeof(ICleanroomsMembershipDefaultResultConfigurationOutputConfiguration), fullyQualifiedName: "aws.cleanroomsMembership.CleanroomsMembershipDefaultResultConfigurationOutputConfiguration")]
    public interface ICleanroomsMembershipDefaultResultConfigurationOutputConfiguration
    {
        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/cleanrooms_membership#s3 CleanroomsMembership#s3}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CleanroomsMembership.ICleanroomsMembershipDefaultResultConfigurationOutputConfigurationS3" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cleanroomsMembership.CleanroomsMembershipDefaultResultConfigurationOutputConfigurationS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICleanroomsMembershipDefaultResultConfigurationOutputConfiguration), fullyQualifiedName: "aws.cleanroomsMembership.CleanroomsMembershipDefaultResultConfigurationOutputConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CleanroomsMembership.ICleanroomsMembershipDefaultResultConfigurationOutputConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/cleanrooms_membership#s3 CleanroomsMembership#s3}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CleanroomsMembership.ICleanroomsMembershipDefaultResultConfigurationOutputConfigurationS3" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cleanroomsMembership.CleanroomsMembershipDefaultResultConfigurationOutputConfigurationS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
