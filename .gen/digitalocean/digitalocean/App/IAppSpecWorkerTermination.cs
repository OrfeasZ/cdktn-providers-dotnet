using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecWorkerTermination), fullyQualifiedName: "digitalocean.app.AppSpecWorkerTermination")]
    public interface IAppSpecWorkerTermination
    {
        /// <summary>The number of seconds to wait between sending a TERM signal to a container and issuing a KILL which causes immediate shutdown.</summary>
        /// <remarks>
        /// Default: 120, Minimum 1, Maximum 600.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#grace_period_seconds App#grace_period_seconds}
        /// </remarks>
        [JsiiProperty(name: "gracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GracePeriodSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecWorkerTermination), fullyQualifiedName: "digitalocean.app.AppSpecWorkerTermination")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecWorkerTermination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The number of seconds to wait between sending a TERM signal to a container and issuing a KILL which causes immediate shutdown.</summary>
            /// <remarks>
            /// Default: 120, Minimum 1, Maximum 600.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#grace_period_seconds App#grace_period_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GracePeriodSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
