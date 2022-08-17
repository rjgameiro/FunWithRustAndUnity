#!/bin/bash
rustup target add wasm32-unknown-emscripten # WebGL with EMScripten
rustup target add aarch64-linux-android     # Android on ARM 64 bits
rustup target add armv7-linux-androideabi   # Android on ARM 32 bits
rustup target add aarch64-apple-darwin      # macOS on Apple Silicon
rustup target add x86_64-apple-darwin       # macOS on Intel
rustup target add aarch64-apple-ios         # iOS