using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Microvm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.microvm.MicrovmSize")]
    public class MicrovmSize : digitalocean.Microvm.IMicrovmSize
    {
        /// <summary>Number of vCPUs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/microvm#cpu Microvm#cpu}
        /// </remarks>
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}")]
        public double Cpu
        {
            get;
            set;
        }

        /// <summary>Memory in MiB.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/microvm#memory Microvm#memory}
        /// </remarks>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
        public double Memory
        {
            get;
            set;
        }
    }
}
