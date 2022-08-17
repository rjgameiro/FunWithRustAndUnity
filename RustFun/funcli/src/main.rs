use fun::*;
use structopt::StructOpt;

#[derive(StructOpt, Debug)]
#[structopt(name = "funcli")]
#[structopt(about = "Increment or decrement values from command line.")]
enum Opt {
    /// Increments a value
    Increment {
        /// The value to increment
        #[structopt(name = "value", required = true)]
        value: i32
    },
    /// Decrements a value
    Decrement {
        /// The value to decrement
        #[structopt(name = "value", required = true)]
        value: i32
    }
}

fn main() {
    match Opt::from_args() {
        Opt::Increment {
            value
        } => {
            println!("incrementing {} results in {}", value, fun_increment(value));
        },
        Opt::Decrement {
            value
        } => {
            println!("decrementing {} results in {}", value, fun_decrement(value));
        }
    }
}
